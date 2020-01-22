namespace DesktopClipboardToolkit
{
    partial class ClipboardItemsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClipboardItemsControl));
            this.buttonClearClipboardMemory = new System.Windows.Forms.Button();
            this.labelClipboardItemsCaption = new System.Windows.Forms.Label();
            this.listBoxSavedClipboardItems = new System.Windows.Forms.ListBox();
            this.labelClipboardItemCount = new System.Windows.Forms.Label();
            this.buttonCreateNewItem = new System.Windows.Forms.Button();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClearClipboardMemory
            // 
            this.buttonClearClipboardMemory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClearClipboardMemory.Location = new System.Drawing.Point(5, 276);
            this.buttonClearClipboardMemory.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearClipboardMemory.Name = "buttonClearClipboardMemory";
            this.buttonClearClipboardMemory.Size = new System.Drawing.Size(210, 37);
            this.buttonClearClipboardMemory.TabIndex = 20;
            this.buttonClearClipboardMemory.Text = "Clear Clipboard Memory";
            this.buttonClearClipboardMemory.UseVisualStyleBackColor = true;
            this.buttonClearClipboardMemory.Click += new System.EventHandler(this.buttonClearClipboardMemory_Click);
            // 
            // labelClipboardItemsCaption
            // 
            this.labelClipboardItemsCaption.AutoSize = true;
            this.labelClipboardItemsCaption.Location = new System.Drawing.Point(0, 0);
            this.labelClipboardItemsCaption.Margin = new System.Windows.Forms.Padding(15);
            this.labelClipboardItemsCaption.Name = "labelClipboardItemsCaption";
            this.labelClipboardItemsCaption.Size = new System.Drawing.Size(109, 20);
            this.labelClipboardItemsCaption.TabIndex = 19;
            this.labelClipboardItemsCaption.Text = "Clipbard items";
            // 
            // listBoxSavedClipboardItems
            // 
            this.listBoxSavedClipboardItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBoxSavedClipboardItems.FormattingEnabled = true;
            this.listBoxSavedClipboardItems.ItemHeight = 20;
            this.listBoxSavedClipboardItems.Location = new System.Drawing.Point(5, 28);
            this.listBoxSavedClipboardItems.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxSavedClipboardItems.Name = "listBoxSavedClipboardItems";
            this.listBoxSavedClipboardItems.ScrollAlwaysVisible = true;
            this.listBoxSavedClipboardItems.Size = new System.Drawing.Size(210, 244);
            this.listBoxSavedClipboardItems.TabIndex = 18;
            this.listBoxSavedClipboardItems.TabStop = false;
            this.listBoxSavedClipboardItems.SelectedIndexChanged += new System.EventHandler(this.listBoxSavedClipboardItems_SelectedIndexChanged);
            // 
            // labelClipboardItemCount
            // 
            this.labelClipboardItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelClipboardItemCount.AutoSize = true;
            this.labelClipboardItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClipboardItemCount.Location = new System.Drawing.Point(127, 5);
            this.labelClipboardItemCount.Name = "labelClipboardItemCount";
            this.labelClipboardItemCount.Size = new System.Drawing.Size(13, 13);
            this.labelClipboardItemCount.TabIndex = 22;
            this.labelClipboardItemCount.Text = "0";
            // 
            // buttonCreateNewItem
            // 
            this.buttonCreateNewItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonCreateNewItem.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewItem.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCreateNewItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonCreateNewItem.Image")));
            this.buttonCreateNewItem.Location = new System.Drawing.Point(225, 148);
            this.buttonCreateNewItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonCreateNewItem.Name = "buttonCreateNewItem";
            this.buttonCreateNewItem.Size = new System.Drawing.Size(30, 34);
            this.buttonCreateNewItem.TabIndex = 26;
            this.buttonCreateNewItem.TabStop = false;
            this.buttonCreateNewItem.UseVisualStyleBackColor = false;
            this.buttonCreateNewItem.Click += new System.EventHandler(this.buttonCreateNewItem_Click);
            this.buttonCreateNewItem.MouseEnter += new System.EventHandler(this.buttonCreateNewItem_MouseEnter);
            this.buttonCreateNewItem.MouseLeave += new System.EventHandler(this.buttonCreateNewItem_MouseLeave);
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonEditItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEditItem.FlatAppearance.BorderSize = 0;
            this.buttonEditItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditItem.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEditItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonEditItem.Image")));
            this.buttonEditItem.Location = new System.Drawing.Point(225, 194);
            this.buttonEditItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(30, 34);
            this.buttonEditItem.TabIndex = 27;
            this.buttonEditItem.TabStop = false;
            this.buttonEditItem.UseVisualStyleBackColor = false;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            this.buttonEditItem.MouseEnter += new System.EventHandler(this.buttonEditItem_MouseEnter);
            this.buttonEditItem.MouseLeave += new System.EventHandler(this.buttonEditItem_MouseLeave);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.BackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDeleteItem.FlatAppearance.BorderSize = 0;
            this.buttonDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteItem.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteItem.Image")));
            this.buttonDeleteItem.Location = new System.Drawing.Point(225, 238);
            this.buttonDeleteItem.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(30, 34);
            this.buttonDeleteItem.TabIndex = 28;
            this.buttonDeleteItem.TabStop = false;
            this.buttonDeleteItem.UseVisualStyleBackColor = false;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            this.buttonDeleteItem.MouseEnter += new System.EventHandler(this.buttonDeleteItem_MouseEnter);
            this.buttonDeleteItem.MouseLeave += new System.EventHandler(this.buttonDeleteItem_MouseLeave);
            // 
            // ClipboardItemsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonEditItem);
            this.Controls.Add(this.buttonCreateNewItem);
            this.Controls.Add(this.labelClipboardItemCount);
            this.Controls.Add(this.buttonClearClipboardMemory);
            this.Controls.Add(this.labelClipboardItemsCaption);
            this.Controls.Add(this.listBoxSavedClipboardItems);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClipboardItemsControl";
            this.Size = new System.Drawing.Size(275, 322);
            this.Load += new System.EventHandler(this.ClipboardItemsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearClipboardMemory;
        private System.Windows.Forms.Label labelClipboardItemsCaption;
        private System.Windows.Forms.ListBox listBoxSavedClipboardItems;
        private System.Windows.Forms.Label labelClipboardItemCount;
        private System.Windows.Forms.Button buttonCreateNewItem;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonDeleteItem;
    }
}
