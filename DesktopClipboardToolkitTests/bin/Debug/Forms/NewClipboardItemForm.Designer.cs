namespace DesktopClipboardToolkit
{
    partial class NewClipboardItemForm
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
            this.buttonCloseNewClipboardItemForm = new System.Windows.Forms.Button();
            this.buttonSaveNewClipboardItem = new System.Windows.Forms.Button();
            this.clipboardItemGeneratorControl = new DesktopClipboardToolkit.ClipboardItemGeneratorControl();
            this.tagUserControlTagsAssignedToClipboardItem = new DesktopClipboardToolkit.TagControl();
            this.SuspendLayout();
            // 
            // buttonCloseNewClipboardItemForm
            // 
            this.buttonCloseNewClipboardItemForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCloseNewClipboardItemForm.Location = new System.Drawing.Point(717, 378);
            this.buttonCloseNewClipboardItemForm.Name = "buttonCloseNewClipboardItemForm";
            this.buttonCloseNewClipboardItemForm.Size = new System.Drawing.Size(75, 34);
            this.buttonCloseNewClipboardItemForm.TabIndex = 36;
            this.buttonCloseNewClipboardItemForm.Text = "Close";
            this.buttonCloseNewClipboardItemForm.UseVisualStyleBackColor = true;
            this.buttonCloseNewClipboardItemForm.Click += new System.EventHandler(this.buttonCloseNewClipboardItemForm_Click);
            // 
            // buttonSaveNewClipboardItem
            // 
            this.buttonSaveNewClipboardItem.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveNewClipboardItem.Location = new System.Drawing.Point(636, 378);
            this.buttonSaveNewClipboardItem.Name = "buttonSaveNewClipboardItem";
            this.buttonSaveNewClipboardItem.Size = new System.Drawing.Size(75, 34);
            this.buttonSaveNewClipboardItem.TabIndex = 37;
            this.buttonSaveNewClipboardItem.Text = "Save";
            this.buttonSaveNewClipboardItem.UseVisualStyleBackColor = true;
            this.buttonSaveNewClipboardItem.Click += new System.EventHandler(this.buttonSaveNewClipboardItem_Click);
            // 
            // clipboardItemGeneratorControl
            // 
            this.clipboardItemGeneratorControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clipboardItemGeneratorControl.ClipboardItemDescriptionTextBoxEnabled = true;
            this.clipboardItemGeneratorControl.CreateButtonVisible = true;
            this.clipboardItemGeneratorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardItemGeneratorControl.Location = new System.Drawing.Point(5, 17);
            this.clipboardItemGeneratorControl.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.clipboardItemGeneratorControl.Name = "clipboardItemGeneratorControl";
            this.clipboardItemGeneratorControl.Size = new System.Drawing.Size(390, 402);
            this.clipboardItemGeneratorControl.TabIndex = 38;
            // 
            // tagUserControlTagsAssignedToClipboardItem
            // 
            this.tagUserControlTagsAssignedToClipboardItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tagUserControlTagsAssignedToClipboardItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tagUserControlTagsAssignedToClipboardItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagUserControlTagsAssignedToClipboardItem.LastFilterSelected = "";
            this.tagUserControlTagsAssignedToClipboardItem.Location = new System.Drawing.Point(407, 17);
            this.tagUserControlTagsAssignedToClipboardItem.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.tagUserControlTagsAssignedToClipboardItem.MaximumSize = new System.Drawing.Size(600, 600);
            this.tagUserControlTagsAssignedToClipboardItem.MinimumSize = new System.Drawing.Size(50, 50);
            this.tagUserControlTagsAssignedToClipboardItem.Name = "tagUserControlTagsAssignedToClipboardItem";
            this.tagUserControlTagsAssignedToClipboardItem.Size = new System.Drawing.Size(394, 354);
            this.tagUserControlTagsAssignedToClipboardItem.TabIndex = 34;
            this.tagUserControlTagsAssignedToClipboardItem.TCM = DesktopClipboardToolkit.TagControlMode.TagsForItem;
            // 
            // NewClipboardItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 424);
            this.ControlBox = false;
            this.Controls.Add(this.clipboardItemGeneratorControl);
            this.Controls.Add(this.buttonSaveNewClipboardItem);
            this.Controls.Add(this.buttonCloseNewClipboardItemForm);
            this.Controls.Add(this.tagUserControlTagsAssignedToClipboardItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NewClipboardItemForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Clipboard Item";
            this.Load += new System.EventHandler(this.NewClipboardItemForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private TagControl tagUserControlTagsAssignedToClipboardItem;
        private System.Windows.Forms.Button buttonCloseNewClipboardItemForm;
        private System.Windows.Forms.Button buttonSaveNewClipboardItem;
        private ClipboardItemGeneratorControl clipboardItemGeneratorControl;
    }
}