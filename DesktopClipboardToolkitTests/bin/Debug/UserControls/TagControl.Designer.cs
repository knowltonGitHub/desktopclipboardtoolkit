namespace DesktopClipboardToolkit
{
    partial class TagControl
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
            this.listBoxFilterByTag = new System.Windows.Forms.ListBox();
            this.labelTagControlCaption = new System.Windows.Forms.Label();
            this.textBoxTag = new System.Windows.Forms.TextBox();
            this.buttonAddTag = new System.Windows.Forms.Button();
            this.buttonDeleteTag = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelListBox = new System.Windows.Forms.Panel();
            this.panelRightSide = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelListBox.SuspendLayout();
            this.panelRightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFilterByTag
            // 
            this.listBoxFilterByTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFilterByTag.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFilterByTag.FormattingEnabled = true;
            this.listBoxFilterByTag.ItemHeight = 20;
            this.listBoxFilterByTag.Location = new System.Drawing.Point(8, 27);
            this.listBoxFilterByTag.Margin = new System.Windows.Forms.Padding(10);
            this.listBoxFilterByTag.Name = "listBoxFilterByTag";
            this.listBoxFilterByTag.ScrollAlwaysVisible = true;
            this.listBoxFilterByTag.Size = new System.Drawing.Size(224, 222);
            this.listBoxFilterByTag.TabIndex = 26;
            this.listBoxFilterByTag.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxFilterByTag_MouseClick);
            // 
            // labelTagControlCaption
            // 
            this.labelTagControlCaption.AutoSize = true;
            this.labelTagControlCaption.Location = new System.Drawing.Point(4, 0);
            this.labelTagControlCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagControlCaption.Name = "labelTagControlCaption";
            this.labelTagControlCaption.Size = new System.Drawing.Size(95, 20);
            this.labelTagControlCaption.TabIndex = 25;
            this.labelTagControlCaption.Text = "Filter by Tag";
            // 
            // textBoxTag
            // 
            this.textBoxTag.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTag.Location = new System.Drawing.Point(8, 254);
            this.textBoxTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTag.Name = "textBoxTag";
            this.textBoxTag.Size = new System.Drawing.Size(224, 26);
            this.textBoxTag.TabIndex = 29;
            // 
            // buttonAddTag
            // 
            this.buttonAddTag.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddTag.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAddTag.FlatAppearance.BorderSize = 0;
            this.buttonAddTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTag.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAddTag.Image = global::DesktopClipboardToolkit.Properties.Resources.item_add;
            this.buttonAddTag.Location = new System.Drawing.Point(7, 126);
            this.buttonAddTag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTag.Name = "buttonAddTag";
            this.buttonAddTag.Size = new System.Drawing.Size(32, 39);
            this.buttonAddTag.TabIndex = 33;
            this.buttonAddTag.TabStop = false;
            this.buttonAddTag.UseVisualStyleBackColor = false;
            this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
            this.buttonAddTag.MouseEnter += new System.EventHandler(this.buttonAddTag_MouseEnter);
            this.buttonAddTag.MouseLeave += new System.EventHandler(this.buttonAddTag_MouseLeave);
            // 
            // buttonDeleteTag
            // 
            this.buttonDeleteTag.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDeleteTag.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonDeleteTag.FlatAppearance.BorderSize = 0;
            this.buttonDeleteTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDeleteTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteTag.ForeColor = System.Drawing.Color.Transparent;
            this.buttonDeleteTag.Image = global::DesktopClipboardToolkit.Properties.Resources.item_delete;
            this.buttonDeleteTag.Location = new System.Drawing.Point(7, 165);
            this.buttonDeleteTag.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.buttonDeleteTag.Name = "buttonDeleteTag";
            this.buttonDeleteTag.Size = new System.Drawing.Size(32, 37);
            this.buttonDeleteTag.TabIndex = 31;
            this.buttonDeleteTag.TabStop = false;
            this.buttonDeleteTag.UseVisualStyleBackColor = false;
            this.buttonDeleteTag.Click += new System.EventHandler(this.buttonDeleteTag_Click);
            this.buttonDeleteTag.MouseEnter += new System.EventHandler(this.buttonDeleteTag_MouseEnter);
            this.buttonDeleteTag.MouseLeave += new System.EventHandler(this.buttonDeleteTag_MouseLeave);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Controls.Add(this.panelListBox);
            this.panelMain.Controls.Add(this.panelRightSide);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(286, 333);
            this.panelMain.TabIndex = 35;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTagControlCaption);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(240, 24);
            this.panelTop.TabIndex = 38;
            // 
            // panelListBox
            // 
            this.panelListBox.Controls.Add(this.textBoxTag);
            this.panelListBox.Controls.Add(this.listBoxFilterByTag);
            this.panelListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListBox.Location = new System.Drawing.Point(0, 0);
            this.panelListBox.Name = "panelListBox";
            this.panelListBox.Size = new System.Drawing.Size(240, 333);
            this.panelListBox.TabIndex = 37;
            // 
            // panelRightSide
            // 
            this.panelRightSide.Controls.Add(this.buttonDeleteTag);
            this.panelRightSide.Controls.Add(this.buttonAddTag);
            this.panelRightSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSide.Location = new System.Drawing.Point(240, 0);
            this.panelRightSide.Name = "panelRightSide";
            this.panelRightSide.Size = new System.Drawing.Size(46, 333);
            this.panelRightSide.TabIndex = 36;
            // 
            // TagControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TagControl";
            this.Size = new System.Drawing.Size(286, 333);
            this.Load += new System.EventHandler(this.TagControl_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelListBox.ResumeLayout(false);
            this.panelListBox.PerformLayout();
            this.panelRightSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxFilterByTag;
        private System.Windows.Forms.Label labelTagControlCaption;
        private System.Windows.Forms.TextBox textBoxTag;
        private System.Windows.Forms.Button buttonAddTag;
        private System.Windows.Forms.Button buttonDeleteTag;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelListBox;
        private System.Windows.Forms.Panel panelRightSide;
    }
}
