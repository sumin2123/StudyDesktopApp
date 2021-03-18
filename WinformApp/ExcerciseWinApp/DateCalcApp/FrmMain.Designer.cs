
namespace DateCalcApp
{
    partial class FrmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "생일을 선택하세요.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "생일로부터 오늘 까지...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "일이 지났습니다.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "세 입니다.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "당신의 연령은 만";
            // 
            // DtpBirthDay
            // 
            this.DtpBirthDay.Location = new System.Drawing.Point(24, 53);
            this.DtpBirthDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtpBirthDay.Name = "DtpBirthDay";
            this.DtpBirthDay.Size = new System.Drawing.Size(202, 25);
            this.DtpBirthDay.TabIndex = 5;
            this.DtpBirthDay.ValueChanged += new System.EventHandler(this.DtpBirthDay_ValueChanged);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(194, 102);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(145, 25);
            this.TxtResult.TabIndex = 6;
            // 
            // TxtYear
            // 
            this.TxtYear.Location = new System.Drawing.Point(194, 137);
            this.TxtYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(145, 25);
            this.TxtYear.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 198);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.DtpBirthDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "날짜계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpBirthDay;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.TextBox TxtYear;
    }
}

