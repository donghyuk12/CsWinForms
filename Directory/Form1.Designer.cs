namespace Dirctory
{
    partial class Form1
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
            this.IbDir = new System.Windows.Forms.ListBox();
            this.IbFiles = new System.Windows.Forms.ListBox();
            this.btnDirList = new System.Windows.Forms.Button();
            this.btnFileList = new System.Windows.Forms.Button();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.cdName = new System.Windows.Forms.ColumnHeader();
            this.cdEx = new System.Windows.Forms.ColumnHeader();
            this.cdTime = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // IbDir
            // 
            this.IbDir.FormattingEnabled = true;
            this.IbDir.ItemHeight = 15;
            this.IbDir.Location = new System.Drawing.Point(23, 22);
            this.IbDir.Name = "IbDir";
            this.IbDir.Size = new System.Drawing.Size(337, 169);
            this.IbDir.TabIndex = 0;
            // 
            // IbFiles
            // 
            this.IbFiles.FormattingEnabled = true;
            this.IbFiles.ItemHeight = 15;
            this.IbFiles.Location = new System.Drawing.Point(23, 216);
            this.IbFiles.Name = "IbFiles";
            this.IbFiles.Size = new System.Drawing.Size(337, 169);
            this.IbFiles.TabIndex = 1;
            // 
            // btnDirList
            // 
            this.btnDirList.Location = new System.Drawing.Point(383, 22);
            this.btnDirList.Name = "btnDirList";
            this.btnDirList.Size = new System.Drawing.Size(121, 37);
            this.btnDirList.TabIndex = 2;
            this.btnDirList.Text = "디렉터리 목록";
            this.btnDirList.UseVisualStyleBackColor = true;
            this.btnDirList.Click += new System.EventHandler(this.btnDirList_Click);
            // 
            // btnFileList
            // 
            this.btnFileList.Location = new System.Drawing.Point(383, 216);
            this.btnFileList.Name = "btnFileList";
            this.btnFileList.Size = new System.Drawing.Size(121, 37);
            this.btnFileList.TabIndex = 3;
            this.btnFileList.Text = "파일 목록";
            this.btnFileList.UseVisualStyleBackColor = true;
            this.btnFileList.Click += new System.EventHandler(this.btnFileList_Click);
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cdName,
            this.cdEx,
            this.cdTime});
            this.lvInfo.Location = new System.Drawing.Point(23, 414);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(337, 163);
            this.lvInfo.TabIndex = 4;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // cdName
            // 
            this.cdName.Text = "이름";
            this.cdName.Width = 90;
            // 
            // cdEx
            // 
            this.cdEx.Text = "확장자";
            this.cdEx.Width = 90;
            // 
            // cdTime
            // 
            this.cdTime.Text = "      시간";
            this.cdTime.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 618);
            this.Controls.Add(this.lvInfo);
            this.Controls.Add(this.btnFileList);
            this.Controls.Add(this.btnDirList);
            this.Controls.Add(this.IbFiles);
            this.Controls.Add(this.IbDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox IbDir;
        private ListBox IbFiles;
        private Button btnDirList;
        private Button btnFileList;
        private ListView lvInfo;
        private ColumnHeader cdName;
        private ColumnHeader cdEx;
        private ColumnHeader cdTime;
    }
}