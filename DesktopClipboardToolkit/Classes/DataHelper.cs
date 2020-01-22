using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace DesktopClipboardToolkit
{
    public static class DataHelper
    {
        public static string DB_FILENAME = "Filename=CBDB.db;";

        private static SqliteConnection m_dbConnection = new SqliteConnection(DB_FILENAME);

        public static void DeleteInformationItemFromDatabase(string infodesc)
        {          
            m_dbConnection.Open();
            string sql = "delete from information_items where info_description = '" + infodesc + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        private static string CreateTagSQLINClause(List<string> soc)
        {
            string tempStr = Helper.EMPTY_STRING;

            if (soc.Count > 0)
            {
                foreach (string temp in soc)
                {
                    tempStr += "'" + temp + "',";
                }

                int lastcomma = tempStr.LastIndexOf(",");

                tempStr = tempStr.Substring(0, lastcomma);

                tempStr = " where tag in (" + tempStr + ")";
            }

            return tempStr;
        }

        public static List<string> GetFilteredInformationItemsList(bool isfiltered, List<string> tagschosen)
        {
            List<string> informationItemsFound = new List<string>();

            m_dbConnection.Open();
            string sql = "select info_description, info_value from information_items order by info_description asc";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();
   

            string sql2 = "select info_item_name from tag_mapping" + CreateTagSQLINClause(tagschosen) + " order by info_item_name asc";
            SqliteCommand command2 = new SqliteCommand(sql2, m_dbConnection);
            SqliteDataReader query2 = command2.ExecuteReader();

            if (!isfiltered)
            {
                while (query.Read())
                {
                    informationItemsFound.Add(query.GetString(0));
                }
            }

            if (isfiltered)
            {
                while (query2.Read())
                {
                    informationItemsFound.Add(query2.GetString(0));
                }
            }

            m_dbConnection.Close();

            return informationItemsFound;
            
        }

        public static void DeleteExistingTag(string tagname)
        {  
            m_dbConnection.Open();
            string sql = "delete from tags where tagname = '" + tagname + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static List<object> GetAllTags()
        {
            List<object> tempTagList = new List<object>();

            m_dbConnection.Open();
            string sql = "select tagname from tags order by tagname asc";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();
    

            while (query.Read())
            {
                string temp = query.GetString(0);
                tempTagList.Add(temp);                
            }

            m_dbConnection.Close();

            return tempTagList;
        }

        public static void AddNewTag(string newtag)
        { 
            m_dbConnection.Open();
            string sql = "insert into tags (tagname) values ('" + Helper.DoubleUpSingleQuotes(newtag) + "')";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static List<object> GetAllTagsForDescription(string description)
        {
            List<object> seltags = new List<object>();
            m_dbConnection.Open();
            string sql = "select tag from tag_mapping where info_item_name = '" + description + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();

            while (query.Read())
            {
                seltags.Add(query.GetString(0));             
            }

            m_dbConnection.Close();

            return seltags;
        }

        public static void DeleteMatchingTags(string infodescription)
        {          
            m_dbConnection.Open();
            string sql = "delete from tag_mapping where info_item_name = '" + infodescription + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void ResetTable(string tablename)
        {
            m_dbConnection.Open();
            string sql = "delete from " + tablename;
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void CreateUserTable()
        {
            m_dbConnection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS 'user' ( 'username' TEXT NOT NULL, 'password' TEXT NOT NULL, 'id' INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE )";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void CreateTagsTable()
        {
            m_dbConnection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS 'tags' ( 'tagname' TEXT NOT NULL, PRIMARY KEY('tagname') )";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void CreateTagMappingTable()
        {
            m_dbConnection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS 'tag_mapping' ( 'tag' TEXT NOT NULL, 'info_item_name' TEXT NOT NULL )";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void CreateInformationItemsTable()
        {
            m_dbConnection.Open();
            string sql = "CREATE TABLE IF NOT EXISTS 'information_items' ( 'info_description' TEXT NOT NULL DEFAULT '', 'info_value' BLOB NOT NULL DEFAULT '' )";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
        }

        public static void TruncateAllTables()
        {
            ResetTable("user");
            ResetTable("tags");
            ResetTable("tag_mapping");
            ResetTable("information_items");
        }
        
        public static void CreateAllTables()
        {
            CreateUserTable();
            CreateTagMappingTable();
            CreateInformationItemsTable();
            CreateTagsTable();
        }

        public static void CreateNewDatabase()
        {
            CreateAllTables();
        }

        public static List<string> GetListOfClipboardItems()
        {
            List<string> entries = new List<string>();

            try
            {
                m_dbConnection.Open();
                string sql = "select info_description, info_value from information_items order by info_description asc";
                SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
                SqliteDataReader query = command.ExecuteReader();
                string iitem;

                while (query.Read())
                {
                    iitem = query.GetString(0);
                    entries.Add(iitem);
                }

                m_dbConnection.Close();
            }
            catch(Microsoft.Data.Sqlite.SqliteException sqle)
            {
                DataHelper.CreateAllTables();
                GetListOfClipboardItems();
            }

            return entries;
        }

        public static void UpdateExistingInformationItem(string tempDofI, string tempVofI, List<string> items)
        {        
            m_dbConnection.Open();
            string sql = "update information_items set info_value = '" + Helper.DoubleUpSingleQuotes(tempVofI) + "' where info_description = '" + Helper.DoubleUpSingleQuotes(tempDofI) + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
            m_dbConnection.Close();
            //First delete matching tags...
            DataHelper.DeleteMatchingTags(tempDofI);

            m_dbConnection.Open();
            //...then re-insert the ones selected
            foreach (var obj in items)
            {
                sql = "insert into tag_mapping (info_item_name, tag) values ('" + Helper.DoubleUpSingleQuotes(tempDofI) + "', '" + Helper.DoubleUpSingleQuotes(obj.ToString()) + "')";
                command = new SqliteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

            m_dbConnection.Close();
        }

        public static string GetValueForDescription(string description)
        {
            string infovaluereturned = Helper.EMPTY_STRING;
            m_dbConnection.Open();
            string sql = "select info_value from information_items where info_description = '" + description + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();
   
            while (query.Read())
            {
                infovaluereturned = query.GetString(0);
            }

            m_dbConnection.Close();

            return infovaluereturned;
        }


        public static string GetUserID(string username, string password)
        {
            string userid = Helper.EMPTY_STRING;
            m_dbConnection.Open();
            string sql = "select id from user where username = '" + username + "' and password = '" + password + "'";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();

            while (query.Read())
            {
                userid = query.GetString(0);
            }

            m_dbConnection.Close();

            Helper.userid = userid;
            Helper.username = username;
            Helper.password = password;

            return userid;
        }

        public static object GetSingleRowValue(string tableName, string columnName, string where)
        {
            object theValue = null;

            m_dbConnection.Open();
            string sql = "select " + columnName + " from " + tableName + " " + where;
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            SqliteDataReader query = command.ExecuteReader();

            while (query.Read())
            {
                theValue = query.GetString(0);
            }

            m_dbConnection.Close();

            return theValue;
        }

        public static void SavePreferencesToDatabase(string fromAddress, 
            string host, 
            string port, 
            string username, 
            string password)
        {
            m_dbConnection.Open();
            string sql = "insert into preferences (UserID, FromAddress, Port, Username, Password, Host) values (" + Helper.userid + ", '" +
                Helper.DoubleUpSingleQuotes(fromAddress) + "', '" +
                Helper.DoubleUpSingleQuotes(port) + "', '" +
                Helper.DoubleUpSingleQuotes(username) + "', '" +
                Helper.DoubleUpSingleQuotes(password) + "', '" +
                Helper.DoubleUpSingleQuotes(host) + "')";

            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            m_dbConnection.Close();
        }


        public static void SaveInformationItemToDatabase(string tempDofI, string tempVofI, List<string> items)
        {       
            m_dbConnection.Open();
            string sql = "insert into information_items (info_description, info_value) values ('" + Helper.DoubleUpSingleQuotes(tempDofI) + "', '" + Helper.DoubleUpSingleQuotes(tempVofI) + "')";
            SqliteCommand command = new SqliteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();

            foreach (string temp in items)
            {
                sql = "insert into tag_mapping (info_item_name, tag) values ('" + Helper.DoubleUpSingleQuotes(tempDofI) + "', '" + Helper.DoubleUpSingleQuotes(temp) + "')";
                command = new SqliteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
            }

            m_dbConnection.Close();
        }  
    }//end of class
}//end of namespace
