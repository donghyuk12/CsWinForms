namespace WinFormsTestApp5
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
            this.name = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.AgeTxt = new System.Windows.Forms.TextBox();
            this.JobTxt = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.delbtn = new System.Windows.Forms.Button();
            this.rebtn = new System.Windows.Forms.Button();
            this.plbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(28, 198);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(42, 15);
            this.name.TabIndex = 1;
            this.name.Text = "이름 : ";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(28, 228);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(42, 15);
            this.age.TabIndex = 2;
            this.age.Text = "나이 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "직업 : ";
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(77, 195);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(100, 23);
            this.NameTxt.TabIndex = 4;
            // 
            // AgeTxt
            // 
            this.AgeTxt.Location = new System.Drawing.Point(76, 225);
            this.AgeTxt.Name = "AgeTxt";
            this.AgeTxt.Size = new System.Drawing.Size(100, 23);
            this.AgeTxt.TabIndex = 5;
            // 
            // JobTxt
            // 
            this.JobTxt.Location = new System.Drawing.Point(77, 255);
            this.JobTxt.Name = "JobTxt";
            this.JobTxt.Size = new System.Drawing.Size(100, 23);
            this.JobTxt.TabIndex = 6;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(306, 174);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 7;
            this.addbtn.Text = "추가";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(76, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 140);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름       ";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "나이    ";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "직업";
            this.columnHeader3.Width = 101;
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(306, 203);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 9;
            this.delbtn.Text = "삭제";
            this.delbtn.UseVisualStyleBackColor = true;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // rebtn
            // 
            this.rebtn.Location = new System.Drawing.Point(306, 232);
            this.rebtn.Name = "rebtn";
            this.rebtn.Size = new System.Drawing.Size(75, 23);
            this.rebtn.TabIndex = 10;
            this.rebtn.Text = "수정";
            this.rebtn.UseVisualStyleBackColor = true;
            this.rebtn.Click += new System.EventHandler(this.rebtn_Click);
            // 
            // plbtn
            // 
            this.plbtn.Location = new System.Drawing.Point(306, 261);
            this.plbtn.Name = "plbtn";
            this.plbtn.Size = new System.Drawing.Size(75, 23);
            this.plbtn.TabIndex = 11;
            this.plbtn.Text = "삽입";
            this.plbtn.UseVisualStyleBackColor = true;
            this.plbtn.Click += new System.EventHandler(this.plbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Location = new System.Drawing.Point(306, 290);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(75, 23);
            this.resetbtn.TabIndex = 12;
            this.resetbtn.Text = "txtreset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 515);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.plbtn);
            this.Controls.Add(this.rebtn);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.JobTxt);
            this.Controls.Add(this.AgeTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label name;
        private Label age;
        private Label label3;
        private TextBox NameTxt;
        private TextBox AgeTxt;
        private TextBox JobTxt;
        private Button addbtn;
        private ColumnHeader 이름;
        private ColumnHeader 나이;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button delbtn;
        private Button rebtn;
        private Button plbtn;
        private Button resetbtn;
    }
}