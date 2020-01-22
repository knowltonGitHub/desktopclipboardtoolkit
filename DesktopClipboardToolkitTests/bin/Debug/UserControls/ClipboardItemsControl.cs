using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using System.Linq.Expressions;

namespace DesktopClipboardToolkit
{
    public partial class ClipboardItemsControl : UserControl, ISupportsEvents
    { 
        public string SelectedItemText = Helper.EMPTY_STRING;

        public ClipboardItemsControl()
        {
         //   this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
        }

        public Button ClipboardItemsAddButton
        {
            get { return buttonCreateNewItem; }
            set { buttonCreateNewItem = value; }
        }

        public Button ClipboardItemsEditButton
        {
            get { return buttonEditItem; }
            set { buttonEditItem = value; }
        }

        public Button ClipboardItemsDeleteButton
        {
            get { return buttonDeleteItem; }
            set { buttonDeleteItem = value; }
        }

        public Button ClearClipboardMemoryButton
        {
            get { return buttonClearClipboardMemory; }
            set { buttonClearClipboardMemory = value; }
        }

        public Label ClipboardItemsCaption
        {
            get { return labelClipboardItemsCaption; }
            set { labelClipboardItemsCaption = value; }
        }

        public Label ItemCount
        {
            get
            {
                return labelClipboardItemCount;
            }

            set
            {
                labelClipboardItemCount = value;
            }
        }

        public ListBox ClipboardItemsListBox
        {
            get
            {
                return this.listBoxSavedClipboardItems;
            }

            set
            {
                this.listBoxSavedClipboardItems = value;
            }
        }

        private CustomEvents _ce = new CustomEvents();
             
        public CustomEvents ce { get { return _ce; } set { _ce = value; } }

        private void buttonClearClipboardMemory_Click(object sender, EventArgs e)
        {
            ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_clearclipboardmemorybuttonclick));
            ce.AppEvent(null, new CustomEventArgs("cleared clipboard memory", EventType.addlogitemtext));
        }

        public void GetFilteredListOfClipboardItems(List<string> filteredList)
        {
            foreach (string ii in filteredList)
            {
                listBoxSavedClipboardItems.Items.Add(ii);
            }

            ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_updatecount));
        }

        public void GetListOfClipboardItems()
        {
            List<string> lii = new List<string>();

            lii = DataHelper.GetListOfClipboardItems();

            foreach (string ii in lii)
            {
                listBoxSavedClipboardItems.Items.Add(ii);
            }

            ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_updatecount));
        }

        private void listBoxSavedClipboardItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_listboxselectedindexchanged));
        }

        private void buttonDeleteUncategorizedInformationItem_Click(object sender, EventArgs e)
        {
            //if (this.listBoxSavedClipboardItems.SelectedItems.Count > 0)
            //{
            //    DataHelper.DeleteInformationItemFromDatabase(this.listBoxSavedClipboardItems.Text);
            //    DataHelper.DeleteMatchingTags(this.listBoxSavedClipboardItems.Text);

            //    ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_deleteclipboarditembuttonclick));

            //    ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_updatecount));
            //}
            //else
            //{
            //    MessageBox.Show("Unable to delete existing item.  Please select an item first.", "Warning");
            //}
        }

        private void buttonCreateNewInformationItem_Click(object sender, EventArgs e)
        {
            //NewClipboardItemForm ncif = new NewClipboardItemForm();

            //Helper.newcim = CIMode.Add;

            //if (ncif.ShowDialog() == DialogResult.OK)
            //{
            //    ce.AppEvent(null, new CustomEventArgs(null, EventType.new_clipboarditem));
            //}
        }

        private void buttonEditInformationItem_Click(object sender, EventArgs e)
        {
            //if (this.ClipboardItemsListBox.SelectedItems.Count > 0)
            //{
            //    NewClipboardItemForm ncif = new NewClipboardItemForm();


            //    ncif.Desc = this.ClipboardItemsListBox.SelectedItem.ToString();

            //    ncif.Val = ((DesktopClipboardToolkit.ClipboardValueControl)this.Parent.Controls.Find("clipboardValueControl", true)[0]).ClipboardValue;

            //    Helper.newcim = CIMode.Edit;

            //    if (ncif.ShowDialog() == DialogResult.OK)
            //    {
            //        ce.AppEvent(null, new CustomEventArgs(null, EventType.update_clipboarditem));
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Unable to edit existing item.  Please select an item first.", "Warning");

            //}
        }

        private void buttonCreateNewItem_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonCreateNewItem, Properties.Resources.item_add_hover);
        }

        private void buttonCreateNewItem_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonCreateNewItem, Properties.Resources.item_add);
        }

        private void ClipboardItemsControl_Load(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonCreateNewItem, Properties.Resources.item_add);
            Helper.ChangeButtonImageResource(buttonEditItem, Properties.Resources.item_edit);
            Helper.ChangeButtonImageResource(buttonDeleteItem, Properties.Resources.item_delete);
        }

        private void buttonEditItem_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonEditItem, Properties.Resources.item_edit_hover);
        }

        private void buttonEditItem_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonEditItem, Properties.Resources.item_edit);
        }

        private void buttonDeleteItem_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonDeleteItem, Properties.Resources.item_delete_hover);
        }

        private void buttonDeleteItem_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonDeleteItem, Properties.Resources.item_delete);
        }

        private void buttonCreateNewItem_Click(object sender, EventArgs e)
        {
            NewClipboardItemForm ncif = new NewClipboardItemForm();

            Helper.newcim = CIMode.Add;

            if (ncif.ShowDialog() == DialogResult.OK)
            {
                ce.AppEvent(null, new CustomEventArgs(null, EventType.new_clipboarditem));
            }
        }

        private void buttonEditItem_Click(object sender, EventArgs e)
        {
            if (this.ClipboardItemsListBox.SelectedItems.Count > 0)
            {
                NewClipboardItemForm ncif = new NewClipboardItemForm();

                ncif.Desc = this.ClipboardItemsListBox.SelectedItem.ToString();

                ncif.Val = ((DesktopClipboardToolkit.ClipboardValueControl)this.Parent.Controls.Find("clipboardValueControl", true)[0]).ClipboardValue;

                Helper.newcim = CIMode.Edit;

                if (ncif.ShowDialog() == DialogResult.OK)
                {
                    ce.AppEvent(((DesktopClipboardToolkit.TagControl)ncif.Controls[3]).GetListOfSelectedTags(), new CustomEventArgs(ncif.Val, EventType.update_clipboarditem));
                }
            }
            else
            {
                MessageBox.Show("Unable to edit existing item.  Please select an item first.", "Warning");
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            if (this.listBoxSavedClipboardItems.SelectedItems.Count > 0)
            {
                DataHelper.DeleteInformationItemFromDatabase(this.listBoxSavedClipboardItems.Text);
                DataHelper.DeleteMatchingTags(this.listBoxSavedClipboardItems.Text);

                ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_deleteclipboarditembuttonclick));

                ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clipboarditemcontrol_updatecount));
            }
            else
            {
                MessageBox.Show("Unable to delete existing item.  Please select an item first.", "Warning");
            }
        }
    }
}
