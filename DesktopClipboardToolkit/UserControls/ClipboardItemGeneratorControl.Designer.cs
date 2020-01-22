namespace DesktopClipboardToolkit
{
    partial class ClipboardItemGeneratorControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardItemGeneratorControl));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescriptionOfInformation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInformationValue = new System.Windows.Forms.TextBox();
            this.buttonCreateNewInformationItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter clipboard item description";
            // 
            // textBoxDescriptionOfInformation
            // 
            this.textBoxDescriptionOfInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescriptionOfInformation.Location = new System.Drawing.Point(4, 25);
            this.textBoxDescriptionOfInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxDescriptionOfInformation.Name = "textBoxDescriptionOfInformation";
            this.textBoxDescriptionOfInformation.Size = new System.Drawing.Size(418, 26);
            this.textBoxDescriptionOfInformation.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter clipboard value";
            // 
            // textBoxInformationValue
            // 
            this.textBoxInformationValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInformationValue.Location = new System.Drawing.Point(4, 95);
            this.textBoxInformationValue.Margin = new System.Windows.Forms.Padding(0, 5, 4, 0);
            this.textBoxInformationValue.Multiline = true;
            this.textBoxInformationValue.Name = "textBoxInformationValue";
            this.textBoxInformationValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInformationValue.Size = new System.Drawing.Size(418, 191);
            this.textBoxInformationValue.TabIndex = 7;
            // 
            // buttonCreateNewInformationItem
            // 
            this.buttonCreateNewInformationItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreateNewInformationItem.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewInformationItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewInformationItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateNewInformationItem.Image")));
            this.buttonCreateNewInformationItem.Location = new System.Drawing.Point(426, 244);
            this.buttonCreateNewInformationItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonCreateNewInformationItem.Name = "buttonCreateNewInformationItem";
            this.buttonCreateNewInformationItem.Size = new System.Drawing.Size(50, 50);
            this.buttonCreateNewInformationItem.TabIndex = 8;
            this.buttonCreateNewInformationItem.UseVisualStyleBackColor = true;
            this.buttonCreateNewInformationItem.Click += new System.EventHandler(this.buttonCreateNewInformationItem_Click);
            // 
            // ClipboardItemGeneratorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonCreateNewInformationItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescriptionOfInformation);
            this.Controls.Add(this.textBoxInformationValue);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClipboardItemGeneratorControl";
            this.Size = new System.Drawing.Size(480, 299);
            this.Load += new System.EventHandler(this.ClipboardItemGeneratorControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescriptionOfInformation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInformationValue;
        private System.Windows.Forms.Button buttonCreateNewInformationItem;
    }
}
