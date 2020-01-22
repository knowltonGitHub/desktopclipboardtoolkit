using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DesktopClipboardToolkit
{

    public enum CIMode
    {
        Add,
        Edit
    }

    public static class Helper
    {
        public static string userid = "";
        public static string username = "";
        public static string password = "";
        public static string toAddress = "";
        public static string tempname = "";
        public static string tempvalue = "";
        public static string temptag = "";

        public static string EMPTY_STRING = "";

        public static int VERT_MARGIN = 10;
        public static int HORIZ_MARGIN = 10;

        public static int HORIZ_MARGIN_SMALL = 5;
        public static int VERT_MARGIN_SMALL = 5;

        public static int STANDARD_X_ZERO = 0;
        public static int STANDARD_Y_ZERO = 0;

        public static int STANDARD_LEFT_MARGIN_ZERO = 0;
        public static int STANDARD_LEFT_INDENT = 4;

        public static int STANDARD_CI_LISTBOX_WIDTH = 400;
        public static int STANDARD_CI_DESCRIPTION_WIDTH = STANDARD_CI_LISTBOX_WIDTH;
        public static int STANDARD_CI_TEXTBOX_WIDTH = STANDARD_CI_LISTBOX_WIDTH;
        public static int STANDARD_TAG_LISTBOX_WIDTH = 250;

        public static CIMode newcim;

        public static List<object> SelectedTags;

        public static String DoubleUpSingleQuotes(string temp)
        {
            string newstr = Helper.EMPTY_STRING;
            newstr = temp.Replace("'", "''");
            return newstr;
        }

        public static void ToggleMouseBorder(ref System.Windows.Forms.Button btn)
        {
            if (btn.FlatAppearance.BorderSize > 0)
            {
                btn.FlatAppearance.BorderSize = 0;
            }
            else
            {
                btn.FlatAppearance.BorderSize = 1;
            }
        }
        public static string CreateSQLINClause(List<string> soc)
        {
            string tempStr = Helper.EMPTY_STRING;

            if (soc.Count > 0)
            {
                foreach (var temp in soc)
                {
                    tempStr += "'" + temp.ToString() + "',";
                }

                int lastcomma = tempStr.LastIndexOf(",");

                tempStr = tempStr.Substring(0, lastcomma);

                tempStr = " where tag in (" + tempStr + ")";
            }

            return tempStr;
        }

        public static void ChangeButtonImageResource(System.Windows.Forms.Button tempButton, System.Drawing.Bitmap bm)
        {
            tempButton.Image = bm;
            tempButton.BackColor = System.Drawing.Color.Transparent;
            tempButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            tempButton.FlatAppearance.BorderSize = 0;
            tempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tempButton.ForeColor = System.Drawing.Color.Transparent;
            tempButton.Margin = new System.Windows.Forms.Padding(0);
            tempButton.UseVisualStyleBackColor = true;           
        }

        public static void Email(string htmlString, 
            string fromAddress,
            string toAddress,
            string Subject,
            string Host,
            int Port,
            string UserName,
            string Password)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress(fromAddress);
                message.To.Add(new MailAddress(toAddress));
                message.Subject = Subject;
                message.IsBodyHtml = false;  
                message.Body = htmlString;
                smtp.Port = Port;
                smtp.Host = Host; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(UserName, Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) 
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }

    }
}