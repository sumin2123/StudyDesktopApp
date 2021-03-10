
namespace PracticeWinApp.Views
{
    partial class FrmChild
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
            this.BtnQ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnQ
            // 
            this.BtnQ.Location = new System.Drawing.Point(107, 18);
            this.BtnQ.Name = "BtnQ";
            this.BtnQ.Size = new System.Drawing.Size(114, 46);
            this.BtnQ.TabIndex = 0;
            this.BtnQ.Text = "질문";
            this.BtnQ.UseVisualStyleBackColor = true;
            this.BtnQ.Click += new System.EventHandler(this.BtnQ_Click);
            // 
            // FrmChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 76);
            this.Controls.Add(this.BtnQ);
            this.Name = "FrmChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "자식폼";
            this.Load += new System.EventHandler(this.FrmChild_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnQ;
    }
}