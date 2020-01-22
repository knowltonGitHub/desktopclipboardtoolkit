using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace DesktopClipboardToolkit
{
    public partial class ClipboardValueControl : UserControl, ISupportsEvents
    {
        private CustomEvents _ce = new CustomEvents();

        public CustomEvents ce { get { return _ce; } set { _ce = value; } }

        public ClipboardValueControl()
        {
            InitializeComponent();
        }

        public Button TreatValueAsURLButton
        {
            get { return buttonTreatClipboardValueAsWebURL; }
            set { buttonTreatClipboardValueAsWebURL = value; }
        }

        public Button SendValueToEmail
        {
            get { return buttonSendEmail; }
            set { buttonSendEmail = value; }
        }

        public Label ClipboardValueCaption
        {
            get { return labelClipboardValueCaption; }
            set { labelClipboardValueCaption = value; }
        }
        public TextBox ClipboardValueTextBox
        {
            get { return textBoxCurClipboardValue; }
            set { textBoxCurClipboardValue = value; }
        }

        private void buttonTreatClipboardValueAsWebURL_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
            process.StartInfo.Arguments = this.textBoxCurClipboardValue.Text.Trim() + " --new-window";
            process.Start();
        }

        public string ClipboardValue
        {
            get { return this.textBoxCurClipboardValue.Text.Trim(); }
            set { this.textBoxCurClipboardValue.Text = value; }
        }

        private void buttonSendEmail_Click(object sender, EventArgs e)
        {

            Helper.tempvalue = this.ClipboardValue;
            GetGMailToAddress ggta = new GetGMailToAddress();

            ggta.Show(this);
        }

        private void buttonSendEmail_MouseEnter(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonSendEmail, Properties.Resources.envelope_green);
        }

        private void buttonSendEmail_MouseLeave(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonSendEmail, Properties.Resources.envelope);
        }

        private void ClipboardValueControl_Load(object sender, EventArgs e)
        {
            Helper.ChangeButtonImageResource(buttonSendEmail, Properties.Resources.envelope);
        }
    }
}