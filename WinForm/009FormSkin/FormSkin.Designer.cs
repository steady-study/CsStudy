namespace _009FormSkin
{
    partial class FormSkin
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
            this.components = new System.ComponentModel.Container();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picStop = new System.Windows.Forms.PictureBox();
            this.picSpeaker = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.picFileOpen = new System.Windows.Forms.PictureBox();
            this.picSpeakerTrack = new System.Windows.Forms.PictureBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.cmsMesu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.스킨ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.표준ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.가벼운ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeakerTrack)).BeginInit();
            this.cmsMesu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMinimize
            // 
            this.picMinimize.Location = new System.Drawing.Point(272, -1);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(28, 27);
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picPlay
            // 
            this.picPlay.Location = new System.Drawing.Point(3, 87);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(25, 27);
            this.picPlay.TabIndex = 1;
            this.picPlay.TabStop = false;
            // 
            // picStop
            // 
            this.picStop.Location = new System.Drawing.Point(50, 87);
            this.picStop.Name = "picStop";
            this.picStop.Size = new System.Drawing.Size(25, 27);
            this.picStop.TabIndex = 2;
            this.picStop.TabStop = false;
            // 
            // picSpeaker
            // 
            this.picSpeaker.Location = new System.Drawing.Point(112, 87);
            this.picSpeaker.Name = "picSpeaker";
            this.picSpeaker.Size = new System.Drawing.Size(29, 27);
            this.picSpeaker.TabIndex = 3;
            this.picSpeaker.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Location = new System.Drawing.Point(306, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(27, 26);
            this.picClose.TabIndex = 4;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picPause
            // 
            this.picPause.Location = new System.Drawing.Point(28, 87);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(25, 27);
            this.picPause.TabIndex = 5;
            this.picPause.TabStop = false;
            // 
            // picFileOpen
            // 
            this.picFileOpen.Location = new System.Drawing.Point(81, 87);
            this.picFileOpen.Name = "picFileOpen";
            this.picFileOpen.Size = new System.Drawing.Size(25, 27);
            this.picFileOpen.TabIndex = 6;
            this.picFileOpen.TabStop = false;
            // 
            // picSpeakerTrack
            // 
            this.picSpeakerTrack.Location = new System.Drawing.Point(128, 123);
            this.picSpeakerTrack.Name = "picSpeakerTrack";
            this.picSpeakerTrack.Size = new System.Drawing.Size(86, 27);
            this.picSpeakerTrack.TabIndex = 7;
            this.picSpeakerTrack.TabStop = false;
            this.picSpeakerTrack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseDown);
            this.picSpeakerTrack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseMove);
            this.picSpeakerTrack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSpeakerTrack_MouseUp);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.ForeColor = System.Drawing.Color.White;
            this.lblVolume.Location = new System.Drawing.Point(238, 87);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(54, 12);
            this.lblVolume.TabIndex = 8;
            this.lblVolume.Text = "volume :";
            // 
            // lvList
            // 
            this.lvList.GridLines = true;
            this.lvList.HideSelection = false;
            this.lvList.Location = new System.Drawing.Point(20, 140);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(280, 209);
            this.lvList.TabIndex = 9;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // cmsMesu
            // 
            this.cmsMesu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.스킨ToolStripMenuItem});
            this.cmsMesu.Name = "cmsMesu";
            this.cmsMesu.Size = new System.Drawing.Size(107, 26);
            // 
            // 스킨ToolStripMenuItem
            // 
            this.스킨ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.표준ToolStripMenuItem,
            this.가벼운ToolStripMenuItem});
            this.스킨ToolStripMenuItem.Name = "스킨ToolStripMenuItem";
            this.스킨ToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.스킨ToolStripMenuItem.Text = "스  킨";
            // 
            // 표준ToolStripMenuItem
            // 
            this.표준ToolStripMenuItem.Name = "표준ToolStripMenuItem";
            this.표준ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.표준ToolStripMenuItem.Text = "표  준";
            this.표준ToolStripMenuItem.Click += new System.EventHandler(this.표준ToolStripMenuItem_Click);
            // 
            // 가벼운ToolStripMenuItem
            // 
            this.가벼운ToolStripMenuItem.Name = "가벼운ToolStripMenuItem";
            this.가벼운ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.가벼운ToolStripMenuItem.Text = "가벼운";
            this.가벼운ToolStripMenuItem.Click += new System.EventHandler(this.가벼운ToolStripMenuItem_Click);
            // 
            // FormSkin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 361);
            this.ContextMenuStrip = this.cmsMesu;
            this.Controls.Add(this.lvList);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.picSpeakerTrack);
            this.Controls.Add(this.picFileOpen);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picSpeaker);
            this.Controls.Add(this.picStop);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.picMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormSkin";
            this.Text = "M Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSkin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormSkin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeaker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileOpen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpeakerTrack)).EndInit();
            this.cmsMesu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picStop;
        private System.Windows.Forms.PictureBox picSpeaker;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.PictureBox picFileOpen;
        private System.Windows.Forms.PictureBox picSpeakerTrack;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ContextMenuStrip cmsMesu;
        private System.Windows.Forms.ToolStripMenuItem 스킨ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 표준ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 가벼운ToolStripMenuItem;
    }
}

