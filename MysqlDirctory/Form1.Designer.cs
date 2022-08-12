namespace MysqlDirctory
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.StrStart = new System.Windows.Forms.ComboBox();
            this.lstView = new System.Windows.Forms.ListView();
            this.quiry = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModify = new System.Windows.Forms.Button();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.txtHidden = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StrStart
            // 
            this.StrStart.FormattingEnabled = true;
            this.StrStart.Location = new System.Drawing.Point(23, 29);
            this.StrStart.Name = "StrStart";
            this.StrStart.Size = new System.Drawing.Size(110, 20);
            this.StrStart.TabIndex = 0;
            // 
            // lstView
            // 
            this.lstView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstView.HideSelection = false;
            this.lstView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstView.Location = new System.Drawing.Point(23, 91);
            this.lstView.Name = "lstView";
            this.lstView.Size = new System.Drawing.Size(576, 323);
            this.lstView.TabIndex = 1;
            this.lstView.UseCompatibleStateImageBehavior = false;
            this.lstView.View = System.Windows.Forms.View.Details;
            this.lstView.SelectedIndexChanged += new System.EventHandler(this.lstView_SelectedIndexChanged);
            // 
            // quiry
            // 
            this.quiry.Location = new System.Drawing.Point(139, 14);
            this.quiry.Name = "quiry";
            this.quiry.Size = new System.Drawing.Size(92, 47);
            this.quiry.TabIndex = 2;
            this.quiry.Text = "조회";
            this.quiry.UseVisualStyleBackColor = true;
            this.quiry.Click += new System.EventHandler(this.quiry_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "코드";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "이름";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "인구";
            this.columnHeader3.Width = 307;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(508, 15);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(91, 47);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(259, 28);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(243, 21);
            this.txtSelect.TabIndex = 4;
            // 
            // txtHidden
            // 
            this.txtHidden.Location = new System.Drawing.Point(259, 56);
            this.txtHidden.Name = "txtHidden";
            this.txtHidden.Size = new System.Drawing.Size(243, 21);
            this.txtHidden.TabIndex = 5;
            this.txtHidden.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 437);
            this.Controls.Add(this.txtHidden);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.quiry);
            this.Controls.Add(this.lstView);
            this.Controls.Add(this.StrStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StrStart;
        private System.Windows.Forms.ListView lstView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button quiry;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.TextBox txtHidden;
    }
}

