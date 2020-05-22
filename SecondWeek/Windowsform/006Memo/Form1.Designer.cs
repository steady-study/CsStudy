namespace _006Memo
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastePToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeDateDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.fdText = new System.Windows.Forms.FontDialog();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNote.Location = new System.Drawing.Point(0, 24);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(525, 388);
            this.txtNote.TabIndex = 0;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.editEToolStripMenuItem,
            this.formatOToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(525, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newNToolStripMenuItem,
            this.openOToolStripMenuItem,
            this.saveSToolStripMenuItem,
            this.saveAsAToolStripMenuItem,
            this.exitXToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // newNToolStripMenuItem
            // 
            this.newNToolStripMenuItem.Name = "newNToolStripMenuItem";
            this.newNToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newNToolStripMenuItem.Text = "New(&N)";
            this.newNToolStripMenuItem.Click += new System.EventHandler(this.newNToolStripMenuItem_Click);
            // 
            // openOToolStripMenuItem
            // 
            this.openOToolStripMenuItem.Name = "openOToolStripMenuItem";
            this.openOToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.openOToolStripMenuItem.Text = "Open(&O)";
            this.openOToolStripMenuItem.Click += new System.EventHandler(this.openOToolStripMenuItem_Click);
            // 
            // saveSToolStripMenuItem
            // 
            this.saveSToolStripMenuItem.Name = "saveSToolStripMenuItem";
            this.saveSToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveSToolStripMenuItem.Text = "Save(&S)";
            this.saveSToolStripMenuItem.Click += new System.EventHandler(this.saveSToolStripMenuItem_Click);
            // 
            // saveAsAToolStripMenuItem
            // 
            this.saveAsAToolStripMenuItem.Name = "saveAsAToolStripMenuItem";
            this.saveAsAToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.saveAsAToolStripMenuItem.Text = "Save As(&A)";
            this.saveAsAToolStripMenuItem.Click += new System.EventHandler(this.saveAsAToolStripMenuItem_Click);
            // 
            // exitXToolStripMenuItem
            // 
            this.exitXToolStripMenuItem.Name = "exitXToolStripMenuItem";
            this.exitXToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitXToolStripMenuItem.Text = "Exit(&X)";
            this.exitXToolStripMenuItem.Click += new System.EventHandler(this.exitXToolStripMenuItem_Click);
            // 
            // editEToolStripMenuItem
            // 
            this.editEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoUToolStripMenuItem,
            this.cutTToolStripMenuItem,
            this.copyCToolStripMenuItem,
            this.pastePToolStripMenuItem,
            this.deleteLToolStripMenuItem,
            this.findPToolStripMenuItem,
            this.selectAllAToolStripMenuItem,
            this.timeDateDToolStripMenuItem});
            this.editEToolStripMenuItem.Name = "editEToolStripMenuItem";
            this.editEToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.editEToolStripMenuItem.Text = "Edit(&E)";
            // 
            // undoUToolStripMenuItem
            // 
            this.undoUToolStripMenuItem.Name = "undoUToolStripMenuItem";
            this.undoUToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoUToolStripMenuItem.Text = "Undo(&U)";
            this.undoUToolStripMenuItem.Click += new System.EventHandler(this.undoUToolStripMenuItem_Click);
            // 
            // cutTToolStripMenuItem
            // 
            this.cutTToolStripMenuItem.Name = "cutTToolStripMenuItem";
            this.cutTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutTToolStripMenuItem.Text = "Cut(&T)";
            this.cutTToolStripMenuItem.Click += new System.EventHandler(this.cutTToolStripMenuItem_Click);
            // 
            // copyCToolStripMenuItem
            // 
            this.copyCToolStripMenuItem.Name = "copyCToolStripMenuItem";
            this.copyCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyCToolStripMenuItem.Text = "Copy(&C)";
            this.copyCToolStripMenuItem.Click += new System.EventHandler(this.copyCToolStripMenuItem_Click);
            // 
            // pastePToolStripMenuItem
            // 
            this.pastePToolStripMenuItem.Name = "pastePToolStripMenuItem";
            this.pastePToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pastePToolStripMenuItem.Text = "Paste(&P)";
            this.pastePToolStripMenuItem.Click += new System.EventHandler(this.pastePToolStripMenuItem_Click);
            // 
            // deleteLToolStripMenuItem
            // 
            this.deleteLToolStripMenuItem.Name = "deleteLToolStripMenuItem";
            this.deleteLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteLToolStripMenuItem.Text = "Delete(&L)";
            this.deleteLToolStripMenuItem.Click += new System.EventHandler(this.deleteLToolStripMenuItem_Click);
            // 
            // findPToolStripMenuItem
            // 
            this.findPToolStripMenuItem.Name = "findPToolStripMenuItem";
            this.findPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.findPToolStripMenuItem.Text = "Find(&P)";
            this.findPToolStripMenuItem.Click += new System.EventHandler(this.findPToolStripMenuItem_Click);
            // 
            // selectAllAToolStripMenuItem
            // 
            this.selectAllAToolStripMenuItem.Name = "selectAllAToolStripMenuItem";
            this.selectAllAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllAToolStripMenuItem.Text = "Select All(&A)";
            this.selectAllAToolStripMenuItem.Click += new System.EventHandler(this.selectAllAToolStripMenuItem_Click);
            // 
            // timeDateDToolStripMenuItem
            // 
            this.timeDateDToolStripMenuItem.Name = "timeDateDToolStripMenuItem";
            this.timeDateDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.timeDateDToolStripMenuItem.Text = "Time/Date(&D)";
            this.timeDateDToolStripMenuItem.Click += new System.EventHandler(this.timeDateDToolStripMenuItem_Click);
            // 
            // formatOToolStripMenuItem
            // 
            this.formatOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapWToolStripMenuItem,
            this.fontFToolStripMenuItem});
            this.formatOToolStripMenuItem.Name = "formatOToolStripMenuItem";
            this.formatOToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.formatOToolStripMenuItem.Text = "Format(&O)";
            // 
            // wordWrapWToolStripMenuItem
            // 
            this.wordWrapWToolStripMenuItem.Name = "wordWrapWToolStripMenuItem";
            this.wordWrapWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.wordWrapWToolStripMenuItem.Text = "Word wrap(&W)";
            this.wordWrapWToolStripMenuItem.Click += new System.EventHandler(this.wordWrapWToolStripMenuItem_Click);
            // 
            // fontFToolStripMenuItem
            // 
            this.fontFToolStripMenuItem.Name = "fontFToolStripMenuItem";
            this.fontFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontFToolStripMenuItem.Text = "Font(&F)";
            this.fontFToolStripMenuItem.Click += new System.EventHandler(this.fontFToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // informationAToolStripMenuItem
            // 
            this.informationAToolStripMenuItem.Name = "informationAToolStripMenuItem";
            this.informationAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.informationAToolStripMenuItem.Text = "Information(&A)";
            this.informationAToolStripMenuItem.Click += new System.EventHandler(this.informationAToolStripMenuItem_Click);
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "텍스트";
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 412);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.menuBar);
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "제목 없음";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsAToolStripMenuItem;        
        private System.Windows.Forms.ToolStripMenuItem exitXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastePToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeDateDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationAToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.FontDialog fdText;
    }
}

