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
    public partial class ClipboardItemGeneratorControl : UserControl, ISupportsEvents
    {
        private CustomEvents _ce = new CustomEvents();

        public CustomEvents ce { get { return _ce; } set { _ce = value; } }


        public ClipboardItemGeneratorControl()
        {
            InitializeComponent();            
        }

        private void buttonCreateNewInformationItem_Click(object sender, EventArgs e)
        {
            ce.AppEvent(sender, new CustomEventArgs(textBoxDescriptionOfInformation.Text, EventType.clipboarditemcontrol_neworupdateclipboarditem));            
        }

        public bool ClipboardItemDescriptionTextBoxEnabled
        {
            get {
                return textBoxDescriptionOfInformation.Enabled;
            }

            set {
                this.textBoxDescriptionOfInformation.Enabled = value;
            }
        }

        public bool CreateButtonVisible
        {
            get {
                return this.buttonCreateNewInformationItem.Visible;
            }
            set {
                this.buttonCreateNewInformationItem.Visible = value;
            }
        }

        public TextBox ClipboardItemDescription
        {
            get
            {
                return this.textBoxDescriptionOfInformation;
            }
            set
            {
                this.textBoxDescriptionOfInformation = value;
            }
        }

        public TextBox ClipboardItemValue
        {
            get
            {
                return this.textBoxInformationValue;
            }
            set
            {
                this.textBoxInformationValue = value;
            }
        }

       

        private void ClipboardItemGeneratorControl_Load(object sender, EventArgs e)
        {
            this.textBoxDescriptionOfInformation.Width = Helper.STANDARD_CI_TEXTBOX_WIDTH;
            this.textBoxInformationValue.Width = Helper.STANDARD_CI_TEXTBOX_WIDTH;
            this.buttonCreateNewInformationItem.Location = new Point(this.textBoxInformationValue.Location.X + this.textBoxInformationValue.Width + Helper.HORIZ_MARGIN_SMALL, this.textBoxInformationValue.Location.Y + this.textBoxInformationValue.Height - this.buttonCreateNewInformationItem.Height + Helper.VERT_MARGIN);

            if(Helper.newcim == CIMode.Edit)
            {
                textBoxDescriptionOfInformation.ReadOnly = true;
                

            }
        }
    }
}
