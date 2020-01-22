using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClipboardToolkit
{
    public partial class Preferences : Form
    {
        public Preferences()
        {
            InitializeComponent();
        }

        private void buttonSavePreferences_Click(object sender, EventArgs e)
        {
            DataHelper.SavePreferencesToDatabase(textBoxFromAddress.Text,
                textBoxHost.Text, 
                textBoxPort.Text, 
                textBoxUsername.Text,
                textBoxPassword.Text);

            Close();
        }

        private void Preferences_Load(object sender, EventArgs e)
        {
            textBoxFromAddress.Text = DataHelper.GetSingleRowValue("preferences", "fromAddress", "where UserID = " + Helper.userid).ToString();
            textBoxHost.Text = DataHelper.GetSingleRowValue("preferences", "host", "where UserID = " + Helper.userid).ToString();
            textBoxPort.Text = DataHelper.GetSingleRowValue("preferences", "port", "where UserID = " + Helper.userid).ToString();
            textBoxUsername.Text = DataHelper.GetSingleRowValue("preferences", "username", "where UserID = " + Helper.userid).ToString();
            textBoxPassword.Text = DataHelper.GetSingleRowValue("preferences", "password", "where UserID = " + Helper.userid).ToString();
        }
    }// end of class
}//end of namespace
