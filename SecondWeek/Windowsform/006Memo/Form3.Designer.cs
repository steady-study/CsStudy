namespace _006Memo
{
    partial class Form3
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
            this.lblAbout01 = new System.Windows.Forms.Label();
            this.lblAbout02 = new System.Windows.Forms.Label();
            this.lblAbout03 = new System.Windows.Forms.Label();
            this.lblAbout04 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAbout01
            // 
            this.lblAbout01.AutoSize = true;
            this.lblAbout01.Location = new System.Drawing.Point(105, 22);
            this.lblAbout01.Name = "lblAbout01";
            this.lblAbout01.Size = new System.Drawing.Size(41, 12);
            this.lblAbout01.TabIndex = 0;
            this.lblAbout01.Text = "메모장";
            // 
            // lblAbout02
            // 
            this.lblAbout02.AutoSize = true;
            this.lblAbout02.Location = new System.Drawing.Point(26, 62);
            this.lblAbout02.Name = "lblAbout02";
            this.lblAbout02.Size = new System.Drawing.Size(189, 12);
            this.lblAbout02.TabIndex = 1;
            this.lblAbout02.Text = "이 제품은 다음 사용자에게 허가됨";
            // 
            // lblAbout03
            // 
            this.lblAbout03.AutoSize = true;
            this.lblAbout03.Location = new System.Drawing.Point(26, 104);
            this.lblAbout03.Name = "lblAbout03";
            this.lblAbout03.Size = new System.Drawing.Size(81, 12);
            this.lblAbout03.TabIndex = 2;
            this.lblAbout03.Text = "사용자 이름 : ";
            // 
            // lblAbout04
            // 
            this.lblAbout04.AutoSize = true;
            this.lblAbout04.Location = new System.Drawing.Point(26, 146);
            this.lblAbout04.Name = "lblAbout04";
            this.lblAbout04.Size = new System.Drawing.Size(81, 12);
            this.lblAbout04.TabIndex = 3;
            this.lblAbout04.Text = "컴퓨터 이름 : ";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(166, 180);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "닫 기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 231);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAbout04);
            this.Controls.Add(this.lblAbout03);
            this.Controls.Add(this.lblAbout02);
            this.Controls.Add(this.lblAbout01);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "메모장 정보";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout01;
        private System.Windows.Forms.Label lblAbout02;
        private System.Windows.Forms.Label lblAbout03;
        private System.Windows.Forms.Label lblAbout04;
        private System.Windows.Forms.Button btnClose;
    }
}