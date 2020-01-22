using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopClipboardToolkit
{
    public enum TagControlMode
    {
        TagsForItem,
        AllTags
    }

    public partial class TagControl : UserControl, ISupportsEvents
    {
        private CustomEvents _ce = new CustomEvents();

        public CustomEvents ce { get { return _ce; } set { _ce = value; } }

        private TagControlMode _tcm;

        private string _lastfilterselected = Helper.EMPTY_STRING;

        public TagControl()
        {
            InitializeComponent();
        }

        public Button DeleteTag
        {
            get { return buttonDeleteTag; }
            set { buttonDeleteTag = value; }
        }

        public Label TagControlCaption
        {
            get { return labelTagControlCaption; }
            set { labelTagControlCaption = value; }
        }

        public TagControlMode TCM
        {
            get
            {
                return _tcm;
            }

            set
            {
                _tcm = value;

                switch(_tcm)
                {
                      case TagControlMode.TagsForItem:
                        this.labelTagControlCaption.Text = "Tag(s) (optional)";
                        this.buttonDeleteTag.Visible = false;
                        this.buttonAddTag.Left = -5;
                        break;
                    case TagControlMode.AllTags:
                        this.labelTagControlCaption.Text = "Filter by Tag";
                        this.textBoxTag.Visible = false;
                        this.buttonAddTag.Visible = false;
                        this.buttonDeleteTag.Visible = true;
                        this.buttonDeleteTag.Left = -5;
                        this.buttonDeleteTag.Top = this.listBoxFilterByTag.Top + this.listBoxFilterByTag.Height - this.buttonDeleteTag.Height + 2;
                        break;                  
                    default:
                        break;
                }
            }
        }
                
        public void GetAllTags()
        {
            listBoxFilterByTag.Items.Clear();
            List<object> tempTagList = DataHelper.GetAllTags();
            foreach(var tag in tempTagList)
            {
                listBoxFilterByTag.Items.Add(tag);
            }
        }

        public TextBox NewTagEntryBox
        {
            get
            {
                return textBoxTag;
            }

            set
            {
                textBoxTag = value;
            }
        }
        public ListBox TagListBox
        {
            get
            {
                return listBoxFilterByTag;
            }
            set
            {
                listBoxFilterByTag = value;
            }
        }

        public string LastFilterSelected
        {
            get
            {
                return this._lastfilterselected;
            }

            set
            {
                this._lastfilterselected = value;
            }
        }

        public List<string> GetListOfSelectedTags()
        {
            List<string> temp = new List<string>();
            ListBox.SelectedObjectCollection soc = listBoxFilterByTag.SelectedItems;

            foreach(object s in soc)
            {
                temp.Add(s.ToString());
            }

            return temp;
        }

        public void SetSelectedTags(List<object> seltags)
        {
            foreach(object o in seltags)
            {
                listBoxFilterByTag.SetSelected(listBoxFilterByTag.Items.IndexOf(o.ToString()), true);
            }
        }

        private void buttonDeleteExistingTag_Click(object sender, EventArgs e)
        {
            ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.tagcontrol_deleteexistingtagbuttonclick));            
        }

        private void buttonAddNewTag_Click(object sender, EventArgs e)
        {
            if (!listBoxFilterByTag.Items.Contains(this.textBoxTag.Text))
            {                
                DataHelper.AddNewTag(this.textBoxTag.Text);
                GetAllTags();
                this.textBoxTag.Text = Helper.EMPTY_STRING;
                ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.tagcontrol_addnewtag));
            }
        }
             
        private void listBoxFilterByTag_MouseClick(object sender, MouseEventArgs e)
        {
          //  HandleListBoxClick(this.listBoxFilterByTag.Text);            
        }

        public void HandleListBoxClick(string chosenText)
        {
            
           // ce.AppEvent(null, new CustomEventArgs(Helper.EMPTY_STRING, EventType.clear_value_textbox));

            string tempnewitem = chosenText;

            if (tempnewitem != _lastfilterselected)
            {
                if (_tcm == TagControlMode.AllTags)
                {

                    _lastfilterselected = this.listBoxFilterByTag.Text;

                    List<string> items = new List<string>();

                    foreach (var item in this.listBoxFilterByTag.SelectedItems)
                    {
                        items.Add(item.ToString());
                    }

                    ce.AppEvent(items, new CustomEventArgs(chosenText, EventType.tagcontrol_processselectedfiltertags));
                }
            }
            else
            {
                listBoxFilterByTag.SelectedItems.Clear();
                _lastfilterselected = Helper.EMPTY_STRING;
                ce.AppEvent(null, new CustomEventArgs(chosenText, EventType.tagcontrol_processselectedfiltertags));
            }
        }

        private void buttonAddTag_Click(object sender, EventArgs e)
        {
            if (!listBoxFilterByTag.Items.Contains(this.textBoxTag.Text))
            {
                DataHelper.AddNewTag(this.textBoxTag.Text);
                GetAllTags();
                listBoxFilterByTag.Text = this.textBoxTag.Text;
                
                int i = listBoxFilterByTag.SelectedIndex;
                listBoxFilterByTag.SetSelected(i, true);
                Helper.SelectedTags = new List<object>() { };
                Helper.SelectedTags.Add(listBoxFilterByTag.Text);
                listBoxFilterByTag.Text = Helper.EMPTY_STRING;
                ce.AppEvent(Helper.SelectedTags, new CustomEventArgs(Helper.EMPTY_STRING, EventType.tagcontrol_addnewtag));
            }
        }

        private void buttonDeleteTag_Click(object sender, EventArgs e)
        {
            ce.AppEvent(sender, new CustomEventArgs(Helper.EMPTY_STRING, EventType.tagcontrol_deleteexistingtagbuttonclick));
        }

        private void buttonDeleteTag_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonDeleteTag, Properties.Resources.item_delete_hover);
        }

        private void buttonDeleteTag_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonDeleteTag, Properties.Resources.item_delete);
        }

        private void buttonAddTag_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonAddTag, Properties.Resources.item_add_hover);
        }

        private void buttonAddTag_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonAddTag, Properties.Resources.item_add);
        }

        private void TagControl_Load(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonAddTag, Properties.Resources.item_add);
            Helper.ChangeButtonImageResource(buttonDeleteTag, Properties.Resources.item_delete);
        }

        private void listBoxFilterByTag_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ListBox)sender).Text;
            HandleListBoxClick(text);
        }
    }
}