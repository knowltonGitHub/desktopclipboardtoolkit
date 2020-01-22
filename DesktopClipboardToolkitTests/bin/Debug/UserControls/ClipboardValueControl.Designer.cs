namespace DesktopClipboardToolkit
{
    partial class ClipboardValueControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelClipboardValueCaption = new System.Windows.Forms.Label();
            this.textBoxCurClipboardValue = new System.Windows.Forms.TextBox();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonTreatClipboardValueAsWebURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelClipboardValueCaption
            // 
            this.labelClipboardValueCaption.AutoSize = true;
            this.labelClipboardValueCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClipboardValueCaption.Location = new System.Drawing.Point(3, 0);
            this.labelClipboardValueCaption.Name = "labelClipboardValueCaption";
            this.labelClipboardValueCaption.Size = new System.Drawing.Size(196, 20);
            this.labelClipboardValueCaption.TabIndex = 0;
            this.labelClipboardValueCaption.Text = "Clipboard value (read-only)";
            // 
            // textBoxCurClipboardValue
            // 
            this.textBoxCurClipboardValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCurClipboardValue.Location = new System.Drawing.Point(7, 29);
            this.textBoxCurClipboardValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxCurClipboardValue.Multiline = true;
            this.textBoxCurClipboardValue.Name = "textBoxCurClipboardValue";
            this.textBoxCurClipboardValue.ReadOnly = true;
            this.textBoxCurClipboardValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCurClipboardValue.Size = new System.Drawing.Size(263, 91);
            this.textBoxCurClipboardValue.TabIndex = 1;
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.AutoSize = true;
            this.buttonSendEmail.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSendEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonSendEmail.FlatAppearance.BorderSize = 0;
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendEmail.Image = global::DesktopClipboardToolkit.Properties.Resources.envelope;
            this.buttonSendEmail.Location = new System.Drawing.Point(71, 137);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(40, 35);
            this.buttonSendEmail.TabIndex = 3;
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonSendEmail_Click);
            this.buttonSendEmail.MouseEnter += new System.EventHandler(this.buttonSendEmail_MouseEnter);
            this.buttonSendEmail.MouseLeave += new System.EventHandler(this.buttonSendEmail_MouseLeave);
            // 
            // buttonTreatClipboardValueAsWebURL
            // 
            this.buttonTreatClipboardValueAsWebURL.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTreatClipboardValueAsWebURL.FlatAppearance.BorderSize = 0;
            this.buttonTreatClipboardValueAsWebURL.Image = global::DesktopClipboardToolkit.Properties.Resources.chrome_icon;
            this.buttonTreatClipboardValueAsWebURL.Location = new System.Drawing.Point(15, 137);
            this.buttonTreatClipboardValueAsWebURL.MaximumSize = new System.Drawing.Size(34, 35);
            this.buttonTreatClipboardValueAsWebURL.Name = "buttonTreatClipboardValueAsWebURL";
            this.buttonTreatClipboardValueAsWebURL.Size = new System.Drawing.Size(34, 35);
            this.buttonTreatClipboardValueAsWebURL.TabIndex = 2;
            this.buttonTreatClipboardValueAsWebURL.UseVisualStyleBackColor = false;
            this.buttonTreatClipboardValueAsWebURL.Click += new System.EventHandler(this.buttonTreatClipboardValueAsWebURL_Click);
            // 
            // ClipboardValueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonSendEmail);
            this.Controls.Add(this.buttonTreatClipboardValueAsWebURL);
            this.Controls.Add(this.textBoxCurClipboardValue);
            this.Controls.Add(this.labelClipboardValueCaption);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ClipboardValueControl";
            this.Size = new System.Drawing.Size(278, 185);
            this.Load += new System.EventHandler(this.ClipboardValueControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClipboardValueCaption;
        private System.Windows.Forms.TextBox textBoxCurClipboardValue;
        private System.Windows.Forms.Button buttonTreatClipboardValueAsWebURL;
        private System.Windows.Forms.Button buttonSendEmail;
    }
}
