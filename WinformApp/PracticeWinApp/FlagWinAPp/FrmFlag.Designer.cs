
namespace FlagWinAPp
{
    partial class GreetingFrm
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
            this.BtnGreeting = new System.Windows.Forms.Button();
            this.LblGreeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGreeting
            // 
            this.BtnGreeting.Location = new System.Drawing.Point(91, 192);
            this.BtnGreeting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnGreeting.Name = "BtnGreeting";
            this.BtnGreeting.Size = new System.Drawing.Size(206, 71);
            this.BtnGreeting.TabIndex = 0;
            this.BtnGreeting.Text = "인사를 합시다!";
            this.BtnGreeting.UseVisualStyleBackColor = true;
            this.BtnGreeting.Click += new System.EventHandler(this.BtnGreeting_Click);
            // 
            // LblGreeting
            // 
            this.LblGreeting.AutoSize = true;
            this.LblGreeting.Location = new System.Drawing.Point(87, 102);
            this.LblGreeting.Name = "LblGreeting";
            this.LblGreeting.Size = new System.Drawing.Size(45, 19);
            this.LblGreeting.TabIndex = 1;
            this.LblGreeting.Text = "인사";
            // 
            // GreetingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 302);
            this.Controls.Add(this.LblGreeting);
            this.Controls.Add(this.BtnGreeting);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GreetingFrm";
            this.Text = "FlagWin";
            this.Load += new System.EventHandler(this.GreetingFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGreeting;
        private System.Windows.Forms.Label LblGreeting;
    }
}

