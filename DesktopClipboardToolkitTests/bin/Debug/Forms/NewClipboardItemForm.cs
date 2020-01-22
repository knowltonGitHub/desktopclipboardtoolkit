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
    public partial class NewClipboardItemForm : Form, ISupportsEvents
    {
        private string _desc = Helper.EMPTY_STRING;
        private string _value = Helper.EMPTY_STRING;

        private CustomEvents _ce = new CustomEvents();

        public CustomEvents ce { get { return _ce; } set { _ce = value; } }


        public NewClipboardItemForm()
        {
            InitializeComponent();
        }

        public string Desc
        {
            get {
                return clipboardItemGeneratorControl.ClipboardItemDescription.Text;
            }

            set {
                clipboardItemGeneratorControl.ClipboardItemDescription.Text = value;
            }
        }

        public string Val
        {
            get {
                return clipboardItemGeneratorControl.ClipboardItemValue.Text;
            }
            set {
                clipboardItemGeneratorControl.ClipboardItemValue.Text = value;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewClipboardItemForm_Load(object sender, EventArgs e)
        {
            tagUserControlTagsAssignedToClipboardItem.GetAllTags();
            clipboardItemGeneratorControl.CreateButtonVisible = false;

            if (Helper.newcim == CIMode.Add)
            {
                buttonSaveNewClipboardItem.Text = "Save";
                this.Text = "Create New Clipboard Item";
            }

            if (Helper.newcim == CIMode.Edit)
            {
                buttonSaveNewClipboardItem.Text = "Update";
                tagUserControlTagsAssignedToClipboardItem.SetSelectedTags(DataHelper.GetAllTagsForDescription(this.Desc));
                this.Text = "Update Existing Clipboard Item";
            }
        }

        private void buttonCloseNewClipboardItemForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSaveNewClipboardItem_Click(object sender, EventArgs e)
        {
            if (this.clipboardItemGeneratorControl.ClipboardItemDescription.Text != Helper.EMPTY_STRING && this.clipboardItemGeneratorControl.ClipboardItemValue.Text != Helper.EMPTY_STRING)
            {
                if (Helper.newcim == CIMode.Edit)
                {
                    DataHelper.UpdateExistingInformationItem(this.clipboardItemGeneratorControl.ClipboardItemDescription.Text, this.clipboardItemGeneratorControl.ClipboardItemValue.Text, tagUserControlTagsAssignedToClipboardItem.GetListOfSelectedTags());
                }

                if (Helper.newcim == CIMode.Add)
                {
                    DataHelper.SaveInformationItemToDatabase(this.clipboardItemGeneratorControl.ClipboardItemDescription.Text, this.clipboardItemGeneratorControl.ClipboardItemValue.Text, tagUserControlTagsAssignedToClipboardItem.GetListOfSelectedTags());
                }

                ce.AppEvent("", new CustomEventArgs("", EventType.new_clipboarditem));
            }
            else
            {
                string tempphrase = Helper.newcim == CIMode.Add ? "create new " : "update existing ";
                MessageBox.Show("Unable to " + tempphrase + " information item.  Is there both a description and a value for the information item?", "Warning");
            }
        }

    }//end class
}//end namespace