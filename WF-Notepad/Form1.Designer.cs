namespace WF_Notepad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainText = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSave = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonCut = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTimeDate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainText
            // 
            this.mainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainText.Location = new System.Drawing.Point(0, 24);
            this.mainText.Margin = new System.Windows.Forms.Padding(2);
            this.mainText.Name = "mainText";
            this.mainText.Size = new System.Drawing.Size(738, 375);
            this.mainText.TabIndex = 1;
            this.mainText.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemEdit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(738, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonOpen,
            this.buttonSave,
            this.buttonSaveAs,
            this.buttonNewWindow,
            this.toolStripSeparator1,
            this.buttonExit});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 22);
            this.menuItemFile.Text = "File";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(145, 22);
            this.buttonOpen.Text = "Open...";
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 22);
            this.buttonSave.Text = "Save";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(145, 22);
            this.buttonSaveAs.Text = "Save As...";
            this.buttonSaveAs.Click += new System.EventHandler(this.buttonSaveAs_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(145, 22);
            this.buttonNewWindow.Text = "New Window";
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // buttonExit
            // 
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(145, 22);
            this.buttonExit.Text = "Exit";
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuItemEdit
            // 
            this.menuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonUndo,
            this.toolStripSeparator2,
            this.buttonCut,
            this.buttonCopy,
            this.buttonPaste,
            this.buttonDelete,
            this.toolStripSeparator3,
            this.buttonSelectAll,
            this.buttonTimeDate});
            this.menuItemEdit.Name = "menuItemEdit";
            this.menuItemEdit.Size = new System.Drawing.Size(39, 22);
            this.menuItemEdit.Text = "Edit";
            // 
            // buttonUndo
            // 
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(180, 22);
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // buttonCut
            // 
            this.buttonCut.Name = "buttonCut";
            this.buttonCut.Size = new System.Drawing.Size(180, 22);
            this.buttonCut.Text = "Cut";
            this.buttonCut.Click += new System.EventHandler(this.buttonCut_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(180, 22);
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonPaste
            // 
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(180, 22);
            this.buttonPaste.Text = "Paste";
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 22);
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(180, 22);
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.Click += new System.EventHandler(this.buttonSelectAll_Click);
            // 
            // buttonTimeDate
            // 
            this.buttonTimeDate.Name = "buttonTimeDate";
            this.buttonTimeDate.Size = new System.Drawing.Size(180, 22);
            this.buttonTimeDate.Text = "Time/Date";
            this.buttonTimeDate.Click += new System.EventHandler(this.buttonTimeDate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(738, 399);
            this.Controls.Add(this.mainText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Untitled";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox mainText;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuItemFile;
        private ToolStripMenuItem buttonSaveAs;
        private ToolStripMenuItem buttonOpen;
        private ToolStripMenuItem buttonNewWindow;
        private ToolStripMenuItem buttonSave;
        private ToolStripMenuItem buttonExit;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem menuItemEdit;
        private ToolStripMenuItem buttonCut;
        private ToolStripMenuItem buttonUndo;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem buttonCopy;
        private ToolStripMenuItem buttonPaste;
        private ToolStripMenuItem buttonDelete;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem buttonSelectAll;
        private ToolStripMenuItem buttonTimeDate;
    }
}