
namespace ListViewApp
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
            this.RdbDetails = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.RdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.LsvProducts = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.제품명 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.단가 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // RdbDetails
            // 
            this.RdbDetails.AutoSize = true;
            this.RdbDetails.Location = new System.Drawing.Point(46, 17);
            this.RdbDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdbDetails.Name = "RdbDetails";
            this.RdbDetails.Size = new System.Drawing.Size(73, 19);
            this.RdbDetails.TabIndex = 0;
            this.RdbDetails.Text = "자세히";
            this.RdbDetails.UseVisualStyleBackColor = true;
            this.RdbDetails.CheckedChanged += new System.EventHandler(this.RdbDetails_CheckedChanged);
            // 
            // RdbList
            // 
            this.RdbList.AutoSize = true;
            this.RdbList.Location = new System.Drawing.Point(194, 17);
            this.RdbList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdbList.Name = "RdbList";
            this.RdbList.Size = new System.Drawing.Size(73, 19);
            this.RdbList.TabIndex = 1;
            this.RdbList.Text = "리스트";
            this.RdbList.UseVisualStyleBackColor = true;
            this.RdbList.CheckedChanged += new System.EventHandler(this.RdbList_CheckedChanged);
            // 
            // RdbSmallIcon
            // 
            this.RdbSmallIcon.AutoSize = true;
            this.RdbSmallIcon.Location = new System.Drawing.Point(342, 17);
            this.RdbSmallIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdbSmallIcon.Name = "RdbSmallIcon";
            this.RdbSmallIcon.Size = new System.Drawing.Size(108, 19);
            this.RdbSmallIcon.TabIndex = 2;
            this.RdbSmallIcon.TabStop = true;
            this.RdbSmallIcon.Text = "작은 아이콘";
            this.RdbSmallIcon.UseVisualStyleBackColor = true;
            this.RdbSmallIcon.CheckedChanged += new System.EventHandler(this.RdbSmallIcon_CheckedChanged);
            // 
            // RdbLargeIcon
            // 
            this.RdbLargeIcon.AutoSize = true;
            this.RdbLargeIcon.Location = new System.Drawing.Point(525, 17);
            this.RdbLargeIcon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RdbLargeIcon.Name = "RdbLargeIcon";
            this.RdbLargeIcon.Size = new System.Drawing.Size(88, 19);
            this.RdbLargeIcon.TabIndex = 3;
            this.RdbLargeIcon.TabStop = true;
            this.RdbLargeIcon.Text = "큰아이콘";
            this.RdbLargeIcon.UseVisualStyleBackColor = true;
            this.RdbLargeIcon.CheckedChanged += new System.EventHandler(this.RdbLargeIcon_CheckedChanged);
            // 
            // LsvProducts
            // 
            this.LsvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.제품명,
            this.단가,
            this.columnHeader1,
            this.columnHeader2});
            this.LsvProducts.FullRowSelect = true;
            this.LsvProducts.GridLines = true;
            this.LsvProducts.HideSelection = false;
            this.LsvProducts.Location = new System.Drawing.Point(12, 48);
            this.LsvProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LsvProducts.Name = "LsvProducts";
            this.LsvProducts.Size = new System.Drawing.Size(685, 299);
            this.LsvProducts.TabIndex = 4;
            this.LsvProducts.UseCompatibleStateImageBehavior = false;
            this.LsvProducts.View = System.Windows.Forms.View.Details;
            this.LsvProducts.SelectedIndexChanged += new System.EventHandler(this.LsvProducts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected : ";
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(330, 356);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(367, 25);
            this.TxtSelected.TabIndex = 6;
            // 
            // 제품명
            // 
            this.제품명.Text = "제품명";
            this.제품명.Width = 207;
            // 
            // 단가
            // 
            this.단가.Text = "단가";
            this.단가.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.단가.Width = 138;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "수량";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "금액";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 125;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 395);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsvProducts);
            this.Controls.Add(this.RdbLargeIcon);
            this.Controls.Add(this.RdbSmallIcon);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbDetails;
        private System.Windows.Forms.RadioButton RdbList;
        private System.Windows.Forms.RadioButton RdbSmallIcon;
        private System.Windows.Forms.RadioButton RdbLargeIcon;
        private System.Windows.Forms.ListView LsvProducts;
        private System.Windows.Forms.ColumnHeader 제품명;
        private System.Windows.Forms.ColumnHeader 단가;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelected;
    }
}

