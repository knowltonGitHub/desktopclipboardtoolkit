namespace DesktopClipboardToolkit
{
    partial class Preferences
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPreferences = new System.Windows.Forms.TabControl();
            this.tabPageEmailPreferences = new System.Windows.Forms.TabPage();
            this.buttonSavePreferences = new System.Windows.Forms.Button();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.label1EmailHost = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1Password = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxFromAddress = new System.Windows.Forms.TextBox();
            this.labelFromAddress = new System.Windows.Forms.Label();
            this.labelExplainEmailSettings = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlPreferences.SuspendLayout();
            this.tabPageEmailPreferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPreferences
            // 
            this.tabControlPreferences.Controls.Add(this.tabPageEmailPreferences);
            this.tabControlPreferences.Controls.Add(this.tabPage2);
            this.tabControlPreferences.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPreferences.Location = new System.Drawing.Point(0, 0);
            this.tabControlPreferences.Name = "tabControlPreferences";
            this.tabControlPreferences.SelectedIndex = 0;
            this.tabControlPreferences.Size = new System.Drawing.Size(647, 219);
            this.tabControlPreferences.TabIndex = 0;
            // 
            // tabPageEmailPreferences
            // 
            this.tabPageEmailPreferences.Controls.Add(this.buttonSavePreferences);
            this.tabPageEmailPreferences.Controls.Add(this.textBoxHost);
            this.tabPageEmailPreferences.Controls.Add(this.label1EmailHost);
            this.tabPageEmailPreferences.Controls.Add(this.textBoxUsername);
            this.tabPageEmailPreferences.Controls.Add(this.labelUsername);
            this.tabPageEmailPreferences.Controls.Add(this.textBoxPassword);
            this.tabPageEmailPreferences.Controls.Add(this.label1Password);
            this.tabPageEmailPreferences.Controls.Add(this.textBoxPort);
            this.tabPageEmailPreferences.Controls.Add(this.labelPort);
            this.tabPageEmailPreferences.Controls.Add(this.textBoxFromAddress);
            this.tabPageEmailPreferences.Controls.Add(this.labelFromAddress);
            this.tabPageEmailPreferences.Controls.Add(this.labelExplainEmailSettings);
            this.tabPageEmailPreferences.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmailPreferences.Name = "tabPageEmailPreferences";
            this.tabPageEmailPreferences.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmailPreferences.Size = new System.Drawing.Size(639, 193);
            this.tabPageEmailPreferences.TabIndex = 0;
            this.tabPageEmailPreferences.Text = "Email";
            this.tabPageEmailPreferences.UseVisualStyleBackColor = true;
            // 
            // buttonSavePreferences
            // 
            this.buttonSavePreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSavePreferences.Location = new System.Drawing.Point(558, 164);
            this.buttonSavePreferences.Name = "buttonSavePreferences";
            this.buttonSavePreferences.Size = new System.Drawing.Size(75, 23);
            this.buttonSavePreferences.TabIndex = 25;
            this.buttonSavePreferences.Text = "Save";
            this.buttonSavePreferences.UseVisualStyleBackColor = true;
            this.buttonSavePreferences.Click += new System.EventHandler(this.buttonSavePreferences_Click);
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(102, 78);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(160, 20);
            this.textBoxHost.TabIndex = 24;
            // 
            // label1EmailHost
            // 
            this.label1EmailHost.AutoSize = true;
            this.label1EmailHost.Location = new System.Drawing.Point(67, 81);
            this.label1EmailHost.Name = "label1EmailHost";
            this.label1EmailHost.Size = new System.Drawing.Size(29, 13);
            this.label1EmailHost.TabIndex = 23;
            this.label1EmailHost.Text = "Host";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(102, 130);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(160, 20);
            this.textBoxUsername.TabIndex = 22;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(41, 133);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(102, 156);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(160, 20);
            this.textBoxPassword.TabIndex = 20;
            // 
            // label1Password
            // 
            this.label1Password.AutoSize = true;
            this.label1Password.Location = new System.Drawing.Point(43, 159);
            this.label1Password.Name = "label1Password";
            this.label1Password.Size = new System.Drawing.Size(53, 13);
            this.label1Password.TabIndex = 19;
            this.label1Password.Text = "Password";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(102, 104);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(160, 20);
            this.textBoxPort.TabIndex = 18;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(70, 107);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(26, 13);
            this.labelPort.TabIndex = 17;
            this.labelPort.Text = "Port";
            // 
            // textBoxFromAddress
            // 
            this.textBoxFromAddress.Location = new System.Drawing.Point(102, 52);
            this.textBoxFromAddress.Name = "textBoxFromAddress";
            this.textBoxFromAddress.Size = new System.Drawing.Size(160, 20);
            this.textBoxFromAddress.TabIndex = 2;
            // 
            // labelFromAddress
            // 
            this.labelFromAddress.AutoSize = true;
            this.labelFromAddress.Location = new System.Drawing.Point(25, 55);
            this.labelFromAddress.Name = "labelFromAddress";
            this.labelFromAddress.Size = new System.Drawing.Size(71, 13);
            this.labelFromAddress.TabIndex = 1;
            this.labelFromAddress.Text = "From Address";
            // 
            // labelExplainEmailSettings
            // 
            this.labelExplainEmailSettings.AutoSize = true;
            this.labelExplainEmailSettings.Location = new System.Drawing.Point(23, 25);
            this.labelExplainEmailSettings.Name = "labelExplainEmailSettings";
            this.labelExplainEmailSettings.Size = new System.Drawing.Size(609, 13);
            this.labelExplainEmailSettings.TabIndex = 0;
            this.labelExplainEmailSettings.Text = "Enter your online web settings for G Mail.  As of the date of this application\'s " +
    "publication, the settings can be located by following";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Preferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 219);
            this.Controls.Add(this.tabControlPreferences);
            this.Name = "Preferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.Preferences_Load);
            this.tabControlPreferences.ResumeLayout(false);
            this.tabPageEmailPreferences.ResumeLayout(false);
            this.tabPageEmailPreferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPreferences;
        private System.Windows.Forms.TabPage tabPageEmailPreferences;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelExplainEmailSettings;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.Label label1EmailHost;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1Password;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.TextBox textBoxFromAddress;
        private System.Windows.Forms.Label labelFromAddress;
        private System.Windows.Forms.Button buttonSavePreferences;
    }
}