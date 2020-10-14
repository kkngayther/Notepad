namespace Form_Notepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.itemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.itemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.itemSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.itemTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.itemZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDefaultZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemNew,
            this.itemOpen,
            this.itemSave,
            this.itemSaveAs,
            this.toolStripSeparator1,
            this.itemExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // itemNew
            // 
            this.itemNew.Name = "itemNew";
            this.itemNew.ShortcutKeyDisplayString = "Crtl + N";
            this.itemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itemNew.Size = new System.Drawing.Size(209, 22);
            this.itemNew.Text = "New";
            this.itemNew.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // itemOpen
            // 
            this.itemOpen.Name = "itemOpen";
            this.itemOpen.ShortcutKeyDisplayString = " Crtl + O";
            this.itemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.itemOpen.Size = new System.Drawing.Size(209, 22);
            this.itemOpen.Text = "Open...";
            this.itemOpen.Click += new System.EventHandler(this.itemOpen_Click);
            // 
            // itemSave
            // 
            this.itemSave.Name = "itemSave";
            this.itemSave.ShortcutKeyDisplayString = "Crtl + S";
            this.itemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.itemSave.Size = new System.Drawing.Size(209, 22);
            this.itemSave.Text = "Save";
            this.itemSave.Click += new System.EventHandler(this.itemSave_Click);
            // 
            // itemSaveAs
            // 
            this.itemSaveAs.Name = "itemSaveAs";
            this.itemSaveAs.ShortcutKeyDisplayString = "Crtl + Shift + S";
            this.itemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.itemSaveAs.Size = new System.Drawing.Size(209, 22);
            this.itemSaveAs.Text = "Save As...";
            this.itemSaveAs.Click += new System.EventHandler(this.itemSaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // itemExit
            // 
            this.itemExit.Name = "itemExit";
            this.itemExit.Size = new System.Drawing.Size(209, 22);
            this.itemExit.Text = "Exit";
            this.itemExit.Click += new System.EventHandler(this.itemExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCut,
            this.itemCopy,
            this.itemPaste,
            this.itemDelete,
            this.toolStripSeparator4,
            this.itemSelectAll,
            this.toolStripSeparator5,
            this.itemTimeDate});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(40, 26);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // itemCut
            // 
            this.itemCut.Name = "itemCut";
            this.itemCut.ShortcutKeyDisplayString = "Crtl + X";
            this.itemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.itemCut.Size = new System.Drawing.Size(180, 22);
            this.itemCut.Text = "Cut";
            this.itemCut.Click += new System.EventHandler(this.itemCut_Click);
            // 
            // itemCopy
            // 
            this.itemCopy.Name = "itemCopy";
            this.itemCopy.ShortcutKeyDisplayString = "Crtl + C";
            this.itemCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.itemCopy.Size = new System.Drawing.Size(180, 22);
            this.itemCopy.Text = "Copy";
            this.itemCopy.Click += new System.EventHandler(this.itemCopy_Click);
            // 
            // itemPaste
            // 
            this.itemPaste.Name = "itemPaste";
            this.itemPaste.ShortcutKeyDisplayString = "Crtl + V";
            this.itemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.itemPaste.Size = new System.Drawing.Size(180, 22);
            this.itemPaste.Text = "Paste";
            this.itemPaste.Click += new System.EventHandler(this.itemPaste_Click);
            // 
            // itemDelete
            // 
            this.itemDelete.Name = "itemDelete";
            this.itemDelete.ShortcutKeyDisplayString = "Del";
            this.itemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.itemDelete.Size = new System.Drawing.Size(180, 22);
            this.itemDelete.Text = "Delete";
            this.itemDelete.Click += new System.EventHandler(this.itemDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // itemSelectAll
            // 
            this.itemSelectAll.Name = "itemSelectAll";
            this.itemSelectAll.ShortcutKeyDisplayString = "Crtl + A";
            this.itemSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.itemSelectAll.Size = new System.Drawing.Size(180, 22);
            this.itemSelectAll.Text = "Select All";
            this.itemSelectAll.Click += new System.EventHandler(this.itemSelectAll_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // itemTimeDate
            // 
            this.itemTimeDate.Name = "itemTimeDate";
            this.itemTimeDate.ShortcutKeyDisplayString = "F5";
            this.itemTimeDate.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.itemTimeDate.Size = new System.Drawing.Size(180, 22);
            this.itemTimeDate.Text = "Time/Date";
            this.itemTimeDate.Click += new System.EventHandler(this.itemTimeDate_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(58, 26);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.CheckOnClick = true;
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 26);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemZoomIn,
            this.itemZoomOut,
            this.restoreDefaultZoomToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // itemZoomIn
            // 
            this.itemZoomIn.Name = "itemZoomIn";
            this.itemZoomIn.ShortcutKeyDisplayString = "Crtl + P";
            this.itemZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.itemZoomIn.Size = new System.Drawing.Size(239, 22);
            this.itemZoomIn.Text = "Zoom In";
            this.itemZoomIn.Click += new System.EventHandler(this.itemZoomIn_Click);
            // 
            // itemZoomOut
            // 
            this.itemZoomOut.Name = "itemZoomOut";
            this.itemZoomOut.ShortcutKeyDisplayString = "Crtl + M";
            this.itemZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.itemZoomOut.Size = new System.Drawing.Size(239, 22);
            this.itemZoomOut.Text = "Zoom Out";
            this.itemZoomOut.Click += new System.EventHandler(this.itemZoomOut_Click);
            // 
            // restoreDefaultZoomToolStripMenuItem
            // 
            this.restoreDefaultZoomToolStripMenuItem.Name = "restoreDefaultZoomToolStripMenuItem";
            this.restoreDefaultZoomToolStripMenuItem.ShortcutKeyDisplayString = "Crtl + 0";
            this.restoreDefaultZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.restoreDefaultZoomToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.restoreDefaultZoomToolStripMenuItem.Text = "Restore Default Zoom";
            this.restoreDefaultZoomToolStripMenuItem.Click += new System.EventHandler(this.restoreDefaultZoomToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtNoiDung);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 420);
            this.panel3.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNoiDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(0, 0);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNoiDung.Size = new System.Drawing.Size(800, 420);
            this.txtNoiDung.TabIndex = 0;
            this.txtNoiDung.WordWrap = false;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text Document|*.txt";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text Document|*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Untitles - Notepad";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemNew;
        private System.Windows.Forms.ToolStripMenuItem itemOpen;
        private System.Windows.Forms.ToolStripMenuItem itemSave;
        private System.Windows.Forms.ToolStripMenuItem itemSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem itemExit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemCut;
        private System.Windows.Forms.ToolStripMenuItem itemCopy;
        private System.Windows.Forms.ToolStripMenuItem itemPaste;
        private System.Windows.Forms.ToolStripMenuItem itemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem itemSelectAll;
        private System.Windows.Forms.ToolStripMenuItem itemTimeDate;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemZoomIn;
        private System.Windows.Forms.ToolStripMenuItem itemZoomOut;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultZoomToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

