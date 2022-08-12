namespace WinFormsTestApp2
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
            this.txt_userInput = new System.Windows.Forms.TextBox();
            this.btnExcute = new System.Windows.Forms.Button();
            this.lb_contain = new System.Windows.Forms.Label();
            this.contain_txt = new System.Windows.Forms.Label();
            this.lb_substring = new System.Windows.Forms.Label();
            this.substring_txt = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Length = new System.Windows.Forms.Label();
            this.length_txt = new System.Windows.Forms.Label();
            this.chk_Test1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chkListTest1 = new System.Windows.Forms.CheckedListBox();
            this.cmbitemCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_userInput
            // 
            this.txt_userInput.Location = new System.Drawing.Point(35, 210);
            this.txt_userInput.Name = "txt_userInput";
            this.txt_userInput.Size = new System.Drawing.Size(214, 23);
            this.txt_userInput.TabIndex = 0;
            this.txt_userInput.Text = "안녕하세요";
            // 
            // btnExcute
            // 
            this.btnExcute.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcute.Location = new System.Drawing.Point(404, 87);
            this.btnExcute.Name = "btnExcute";
            this.btnExcute.Size = new System.Drawing.Size(150, 51);
            this.btnExcute.TabIndex = 1;
            this.btnExcute.Text = "(button)\r\n실행\r\n";
            this.btnExcute.UseVisualStyleBackColor = false;
            this.btnExcute.Click += new System.EventHandler(this.btnExcute_Click);
            // 
            // lb_contain
            // 
            this.lb_contain.AutoSize = true;
            this.lb_contain.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_contain.Location = new System.Drawing.Point(35, 90);
            this.lb_contain.Name = "lb_contain";
            this.lb_contain.Size = new System.Drawing.Size(69, 21);
            this.lb_contain.TabIndex = 2;
            this.lb_contain.Text = "Contain";
            // 
            // contain_txt
            // 
            this.contain_txt.AutoSize = true;
            this.contain_txt.Location = new System.Drawing.Point(121, 95);
            this.contain_txt.Name = "contain_txt";
            this.contain_txt.Size = new System.Drawing.Size(12, 15);
            this.contain_txt.TabIndex = 3;
            this.contain_txt.Text = "-";
            // 
            // lb_substring
            // 
            this.lb_substring.AutoSize = true;
            this.lb_substring.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_substring.Location = new System.Drawing.Point(35, 123);
            this.lb_substring.Name = "lb_substring";
            this.lb_substring.Size = new System.Drawing.Size(82, 21);
            this.lb_substring.TabIndex = 4;
            this.lb_substring.Text = "Substring";
            // 
            // substring_txt
            // 
            this.substring_txt.AutoSize = true;
            this.substring_txt.Location = new System.Drawing.Point(121, 128);
            this.substring_txt.Name = "substring_txt";
            this.substring_txt.Size = new System.Drawing.Size(12, 15);
            this.substring_txt.TabIndex = 5;
            this.substring_txt.Text = "-";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("맑은 고딕", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(105, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(380, 40);
            this.name.TabIndex = 6;
            this.name.Text = "(label)WinForm_StringTest";
            this.name.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(404, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "초기화";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Length
            // 
            this.lb_Length.AutoSize = true;
            this.lb_Length.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Length.Location = new System.Drawing.Point(35, 160);
            this.lb_Length.Name = "lb_Length";
            this.lb_Length.Size = new System.Drawing.Size(63, 21);
            this.lb_Length.TabIndex = 9;
            this.lb_Length.Text = "Length";
            // 
            // length_txt
            // 
            this.length_txt.AutoSize = true;
            this.length_txt.Location = new System.Drawing.Point(121, 165);
            this.length_txt.Name = "length_txt";
            this.length_txt.Size = new System.Drawing.Size(12, 15);
            this.length_txt.TabIndex = 12;
            this.length_txt.Text = "-";
            // 
            // chk_Test1
            // 
            this.chk_Test1.AllowDrop = true;
            this.chk_Test1.AutoSize = true;
            this.chk_Test1.BackgroundImage = global::WinFormsTestApp2.Properties.Resources.asd;
            this.chk_Test1.Location = new System.Drawing.Point(35, 251);
            this.chk_Test1.Name = "chk_Test1";
            this.chk_Test1.Size = new System.Drawing.Size(81, 19);
            this.chk_Test1.TabIndex = 13;
            this.chk_Test1.Text = "체크선택1";
            this.chk_Test1.UseVisualStyleBackColor = true;
            this.chk_Test1.CheckedChanged += new System.EventHandler(this.chk_Test1_CheckedChanged);
            this.chk_Test1.Click += new System.EventHandler(this.chk_Test1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(35, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chkListTest1
            // 
            this.chkListTest1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkListTest1.FormattingEnabled = true;
            this.chkListTest1.Items.AddRange(new object[] {
            "테스트1",
            "테스트2",
            "테스트3"});
            this.chkListTest1.Location = new System.Drawing.Point(404, 219);
            this.chkListTest1.Name = "chkListTest1";
            this.chkListTest1.Size = new System.Drawing.Size(67, 58);
            this.chkListTest1.TabIndex = 15;
            this.chkListTest1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chkListTest1_ItemCheck);
            this.chkListTest1.SelectedIndexChanged += new System.EventHandler(this.chkListTest1_SelectedIndexChanged);
            // 
            // cmbitemCombo
            // 
            this.cmbitemCombo.FormattingEnabled = true;
            this.cmbitemCombo.Items.AddRange(new object[] {
            "항목1",
            "항목2",
            "항목3"});
            this.cmbitemCombo.Location = new System.Drawing.Point(404, 297);
            this.cmbitemCombo.Name = "cmbitemCombo";
            this.cmbitemCombo.Size = new System.Drawing.Size(132, 23);
            this.cmbitemCombo.TabIndex = 16;
            this.cmbitemCombo.SelectedIndexChanged += new System.EventHandler(this.cmbitemCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 358);
            this.Controls.Add(this.cmbitemCombo);
            this.Controls.Add(this.chkListTest1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chk_Test1);
            this.Controls.Add(this.length_txt);
            this.Controls.Add(this.lb_Length);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.substring_txt);
            this.Controls.Add(this.lb_substring);
            this.Controls.Add(this.contain_txt);
            this.Controls.Add(this.lb_contain);
            this.Controls.Add(this.btnExcute);
            this.Controls.Add(this.txt_userInput);
            this.Name = "Form1";
            this.Text = "테스트";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_userInput;
        private Button btnExcute;
        private Label lb_contain;
        private Label contain_txt;
        private Label lb_substring;
        private Label substring_txt;
        private Label name;
        private Button button1;
        private Label lb_Length;
        private Label length_txt;
        private CheckBox chk_Test1;
        private CheckBox checkBox1;
        private CheckedListBox chkListTest1;
        private ComboBox cmbitemCombo;
    }
}