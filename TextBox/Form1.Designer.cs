namespace TextBox
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
            this.openbtn = new System.Windows.Forms.Button();
            this.fontbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.colorbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(59, 31);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(96, 50);
            this.openbtn.TabIndex = 0;
            this.openbtn.Text = "열기";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // fontbtn
            // 
            this.fontbtn.Location = new System.Drawing.Point(192, 31);
            this.fontbtn.Name = "fontbtn";
            this.fontbtn.Size = new System.Drawing.Size(96, 50);
            this.fontbtn.TabIndex = 1;
            this.fontbtn.Text = "폰트설정";
            this.fontbtn.UseVisualStyleBackColor = true;
            this.fontbtn.Click += new System.EventHandler(this.fontbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(59, 102);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(96, 50);
            this.savebtn.TabIndex = 2;
            this.savebtn.Text = "저장";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // colorbtn
            // 
            this.colorbtn.Location = new System.Drawing.Point(192, 102);
            this.colorbtn.Name = "colorbtn";
            this.colorbtn.Size = new System.Drawing.Size(96, 50);
            this.colorbtn.TabIndex = 3;
            this.colorbtn.Text = "색상설정";
            this.colorbtn.UseVisualStyleBackColor = true;
            this.colorbtn.Click += new System.EventHandler(this.colorbtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 246);
            this.textBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.colorbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.fontbtn);
            this.Controls.Add(this.openbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button openbtn;
        private Button fontbtn;
        private Button savebtn;
        private Button colorbtn;
        private System.Windows.Forms.TextBox textBox1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}