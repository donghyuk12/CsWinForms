namespace WinFormsTestApp7
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
            this.cLstBox = new System.Windows.Forms.CheckedListBox();
            this.lstBox = new System.Windows.Forms.CheckedListBox();
            this.smoveRight = new System.Windows.Forms.Button();
            this.amoveRight = new System.Windows.Forms.Button();
            this.smoveLeft = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cLstBox
            // 
            this.cLstBox.CheckOnClick = true;
            this.cLstBox.FormattingEnabled = true;
            this.cLstBox.Location = new System.Drawing.Point(39, 94);
            this.cLstBox.Name = "cLstBox";
            this.cLstBox.Size = new System.Drawing.Size(199, 292);
            this.cLstBox.TabIndex = 0;
            // 
            // lstBox
            // 
            this.lstBox.CheckOnClick = true;
            this.lstBox.FormattingEnabled = true;
            this.lstBox.Location = new System.Drawing.Point(407, 94);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(199, 292);
            this.lstBox.TabIndex = 1;
            // 
            // smoveRight
            // 
            this.smoveRight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smoveRight.Location = new System.Drawing.Point(285, 188);
            this.smoveRight.Name = "smoveRight";
            this.smoveRight.Size = new System.Drawing.Size(75, 30);
            this.smoveRight.TabIndex = 2;
            this.smoveRight.Text = ">";
            this.smoveRight.UseVisualStyleBackColor = false;
            this.smoveRight.Click += new System.EventHandler(this.smoveRight_Click);
            // 
            // amoveRight
            // 
            this.amoveRight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.amoveRight.Location = new System.Drawing.Point(285, 224);
            this.amoveRight.Name = "amoveRight";
            this.amoveRight.Size = new System.Drawing.Size(75, 30);
            this.amoveRight.TabIndex = 3;
            this.amoveRight.Text = ">>";
            this.amoveRight.UseVisualStyleBackColor = false;
            this.amoveRight.Click += new System.EventHandler(this.amoveRight_Click);
            // 
            // smoveLeft
            // 
            this.smoveLeft.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.smoveLeft.Location = new System.Drawing.Point(285, 260);
            this.smoveLeft.Name = "smoveLeft";
            this.smoveLeft.Size = new System.Drawing.Size(75, 30);
            this.smoveLeft.TabIndex = 4;
            this.smoveLeft.Text = "<";
            this.smoveLeft.UseVisualStyleBackColor = false;
            this.smoveLeft.Click += new System.EventHandler(this.smoveLeft_Click);
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.delbtn.Location = new System.Drawing.Point(511, 404);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(95, 30);
            this.delbtn.TabIndex = 5;
            this.delbtn.Text = "모두 삭제";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 504);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.smoveLeft);
            this.Controls.Add(this.amoveRight);
            this.Controls.Add(this.smoveRight);
            this.Controls.Add(this.lstBox);
            this.Controls.Add(this.cLstBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox cLstBox;
        private CheckedListBox lstBox;
        private Button smoveRight;
        private Button amoveRight;
        private Button smoveLeft;
        private Button delbtn;
    }
}