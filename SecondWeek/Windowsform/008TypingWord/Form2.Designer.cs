namespace _008TypingWord
{
    partial class Form2
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
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblKind = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.cbGrade = new System.Windows.Forms.ComboBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.lvWord = new System.Windows.Forms.ListView();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cbWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(27, 43);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(37, 12);
            this.lblGrade.TabIndex = 0;
            this.lblGrade.Text = "단계 :";
            // 
            // lblKind
            // 
            this.lblKind.AutoSize = true;
            this.lblKind.Location = new System.Drawing.Point(238, 43);
            this.lblKind.Name = "lblKind";
            this.lblKind.Size = new System.Drawing.Size(37, 12);
            this.lblKind.TabIndex = 1;
            this.lblKind.Text = "종류 :";
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(27, 88);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(33, 12);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "단어 ";
            // 
            // cbGrade
            // 
            this.cbGrade.FormattingEnabled = true;
            this.cbGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbGrade.Location = new System.Drawing.Point(71, 40);
            this.cbGrade.Name = "cbGrade";
            this.cbGrade.Size = new System.Drawing.Size(121, 20);
            this.cbGrade.TabIndex = 3;
            // 
            // cbKind
            // 
            this.cbKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Items.AddRange(new object[] {
            "한글",
            "영어"});
            this.cbKind.Location = new System.Drawing.Point(282, 40);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(121, 20);
            this.cbKind.TabIndex = 4;
            this.cbKind.SelectedIndexChanged += new System.EventHandler(this.cbKind_SelectedIndexChanged);
            // 
            // lvWord
            // 
            this.lvWord.BackColor = System.Drawing.SystemColors.Window;
            this.lvWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cbWord});
            this.lvWord.GridLines = true;
            this.lvWord.HideSelection = false;
            this.lvWord.Location = new System.Drawing.Point(71, 88);
            this.lvWord.Name = "lvWord";
            this.lvWord.Size = new System.Drawing.Size(196, 137);
            this.lvWord.TabIndex = 5;
            this.lvWord.UseCompatibleStateImageBehavior = false;
            this.lvWord.View = System.Windows.Forms.View.Details;
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(282, 88);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(121, 21);
            this.txtInsert.TabIndex = 6;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(282, 131);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "단어 추가";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(29, 253);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(374, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "환 경 설 정";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbWord
            // 
            this.cbWord.Text = "단 어";
            this.cbWord.Width = 170;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 311);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.lvWord);
            this.Controls.Add(this.cbKind);
            this.Controls.Add(this.cbGrade);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblKind);
            this.Controls.Add(this.lblGrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "환경설정";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblKind;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.ComboBox cbGrade;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.ListView lvWord;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColumnHeader cbWord;
    }
}