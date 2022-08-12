namespace WinFormsAppRedis
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_key = new System.Windows.Forms.TextBox();
            this.txt_val = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RedisConnect = new System.Windows.Forms.Button();
            this.RedisSet = new System.Windows.Forms.Button();
            this.RedisGet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "key";
            // 
            // txt_key
            // 
            this.txt_key.Location = new System.Drawing.Point(77, 65);
            this.txt_key.Name = "txt_key";
            this.txt_key.Size = new System.Drawing.Size(247, 23);
            this.txt_key.TabIndex = 1;
            // 
            // txt_val
            // 
            this.txt_val.Location = new System.Drawing.Point(77, 146);
            this.txt_val.Name = "txt_val";
            this.txt_val.Size = new System.Drawing.Size(247, 23);
            this.txt_val.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "value";
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(77, 227);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(247, 23);
            this.txt_result.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "result";
            // 
            // RedisConnect
            // 
            this.RedisConnect.Location = new System.Drawing.Point(33, 296);
            this.RedisConnect.Name = "RedisConnect";
            this.RedisConnect.Size = new System.Drawing.Size(75, 23);
            this.RedisConnect.TabIndex = 6;
            this.RedisConnect.Text = "connection";
            this.RedisConnect.UseVisualStyleBackColor = true;
            this.RedisConnect.Click += new System.EventHandler(this.RedisConnect_Click);
            // 
            // RedisSet
            // 
            this.RedisSet.Location = new System.Drawing.Point(131, 296);
            this.RedisSet.Name = "RedisSet";
            this.RedisSet.Size = new System.Drawing.Size(75, 23);
            this.RedisSet.TabIndex = 7;
            this.RedisSet.Text = "set";
            this.RedisSet.UseVisualStyleBackColor = true;
            this.RedisSet.Click += new System.EventHandler(this.RedisSet_Click);
            // 
            // RedisGet
            // 
            this.RedisGet.Location = new System.Drawing.Point(233, 296);
            this.RedisGet.Name = "RedisGet";
            this.RedisGet.Size = new System.Drawing.Size(75, 23);
            this.RedisGet.TabIndex = 8;
            this.RedisGet.Text = "get";
            this.RedisGet.UseVisualStyleBackColor = true;
            this.RedisGet.Click += new System.EventHandler(this.RedisGet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 349);
            this.Controls.Add(this.RedisGet);
            this.Controls.Add(this.RedisSet);
            this.Controls.Add(this.RedisConnect);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_key);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_key;
        private TextBox txt_val;
        private Label label2;
        private TextBox txt_result;
        private Label label3;
        private Button RedisConnect;
        private Button RedisSet;
        private Button RedisGet;
    }
}