namespace TabControl
{
    partial class CalcWin
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblParents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSend.Location = new System.Drawing.Point(394, 35);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 45);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(47, 47);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(221, 23);
            this.txtData.TabIndex = 1;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(47, 95);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(221, 23);
            this.txtString.TabIndex = 2;
            // 
            // lblParents
            // 
            this.lblParents.AutoSize = true;
            this.lblParents.Location = new System.Drawing.Point(47, 19);
            this.lblParents.Name = "lblParents";
            this.lblParents.Size = new System.Drawing.Size(0, 15);
            this.lblParents.TabIndex = 3;
            // 
            // CalcWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 450);
            this.Controls.Add(this.lblParents);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSend);
            this.Name = "CalcWin";
            this.Text = "CalcWin";
            this.Load += new System.EventHandler(this.CalcWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSend;
        private TextBox txtData;
        private TextBox txtString;
        private Label lblParents;
    }
}