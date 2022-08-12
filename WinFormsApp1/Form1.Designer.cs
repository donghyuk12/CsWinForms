namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.TextBox();
            this.num1_text = new System.Windows.Forms.TextBox();
            this.num2_text = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.resetbox = new System.Windows.Forms.Button();
            this.chkList = new System.Windows.Forms.CheckedListBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.bntContain = new System.Windows.Forms.Button();
            this.buttonbox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.iconbox = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.hsbItem1 = new System.Windows.Forms.HScrollBar();
            this.pbItem = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnstart = new System.Windows.Forms.Button();
            this.dmDept = new System.Windows.Forms.DomainUpDown();
            this.nmSales = new System.Windows.Forms.NumericUpDown();
            this.btnstep = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.buttonbox.SuspendLayout();
            this.iconbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "결과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "값1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(202, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "값2";
            // 
            // result_text
            // 
            this.result_text.Location = new System.Drawing.Point(90, 48);
            this.result_text.Name = "result_text";
            this.result_text.Size = new System.Drawing.Size(241, 23);
            this.result_text.TabIndex = 3;
            this.result_text.TextChanged += new System.EventHandler(this.num1_TextChanged);
            this.result_text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.result_text_KeyDown);
            this.result_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.result_text_KeyPress);
            // 
            // num1_text
            // 
            this.num1_text.Location = new System.Drawing.Point(87, 124);
            this.num1_text.Name = "num1_text";
            this.num1_text.Size = new System.Drawing.Size(92, 23);
            this.num1_text.TabIndex = 4;
            // 
            // num2_text
            // 
            this.num2_text.Location = new System.Drawing.Point(240, 124);
            this.num2_text.Name = "num2_text";
            this.num2_text.Size = new System.Drawing.Size(91, 23);
            this.num2_text.TabIndex = 5;
            this.num2_text.TextChanged += new System.EventHandler(this.num2_text_TextChanged);
            // 
            // add
            // 
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(42, 166);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 46);
            this.add.TabIndex = 6;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Calculate);
            // 
            // min
            // 
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.min.Location = new System.Drawing.Point(123, 166);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(56, 46);
            this.min.TabIndex = 7;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.Calculate);
            // 
            // mul
            // 
            this.mul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mul.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mul.Location = new System.Drawing.Point(213, 166);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(56, 46);
            this.mul.TabIndex = 8;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = true;
            this.mul.Click += new System.EventHandler(this.Calculate);
            // 
            // div
            // 
            this.div.Cursor = System.Windows.Forms.Cursors.Hand;
            this.div.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.div.Location = new System.Drawing.Point(299, 166);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(56, 46);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.Calculate);
            // 
            // resetbox
            // 
            this.resetbox.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resetbox.Location = new System.Drawing.Point(347, 46);
            this.resetbox.Name = "resetbox";
            this.resetbox.Size = new System.Drawing.Size(56, 26);
            this.resetbox.TabIndex = 10;
            this.resetbox.Text = "reset";
            this.resetbox.UseVisualStyleBackColor = true;
            this.resetbox.Click += new System.EventHandler(this.resetbox_Click);
            // 
            // chkList
            // 
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(29, 253);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(171, 40);
            this.chkList.TabIndex = 11;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(231, 253);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 23);
            this.txtAdd.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(363, 253);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(363, 282);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // bntContain
            // 
            this.bntContain.Location = new System.Drawing.Point(363, 311);
            this.bntContain.Name = "bntContain";
            this.bntContain.Size = new System.Drawing.Size(75, 23);
            this.bntContain.TabIndex = 15;
            this.bntContain.Text = "부분삭제";
            this.bntContain.UseVisualStyleBackColor = true;
            this.bntContain.Click += new System.EventHandler(this.bntContain_Click);
            // 
            // buttonbox
            // 
            this.buttonbox.Controls.Add(this.radioButton3);
            this.buttonbox.Controls.Add(this.radioButton2);
            this.buttonbox.Controls.Add(this.radioButton1);
            this.buttonbox.Location = new System.Drawing.Point(40, 383);
            this.buttonbox.Name = "buttonbox";
            this.buttonbox.Size = new System.Drawing.Size(160, 113);
            this.buttonbox.TabIndex = 17;
            this.buttonbox.TabStop = false;
            this.buttonbox.Text = "buttons";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 79);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(19, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // iconbox
            // 
            this.iconbox.Controls.Add(this.radioButton6);
            this.iconbox.Controls.Add(this.radioButton5);
            this.iconbox.Controls.Add(this.radioButton4);
            this.iconbox.Location = new System.Drawing.Point(231, 383);
            this.iconbox.Name = "iconbox";
            this.iconbox.Size = new System.Drawing.Size(172, 113);
            this.iconbox.TabIndex = 18;
            this.iconbox.TabStop = false;
            this.iconbox.Text = "icon";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(18, 79);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(95, 19);
            this.radioButton6.TabIndex = 2;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "radioButton6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(18, 54);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(95, 19);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "radioButton5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(18, 31);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(95, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // cmb_item
            // 
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(29, 299);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(121, 23);
            this.cmb_item.TabIndex = 20;
            // 
            // hsbItem1
            // 
            this.hsbItem1.Location = new System.Drawing.Point(468, 48);
            this.hsbItem1.Name = "hsbItem1";
            this.hsbItem1.Size = new System.Drawing.Size(110, 35);
            this.hsbItem1.TabIndex = 21;
            this.hsbItem1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbItem1_Scroll);
            // 
            // pbItem
            // 
            this.pbItem.Enabled = false;
            this.pbItem.Location = new System.Drawing.Point(379, 122);
            this.pbItem.Name = "pbItem";
            this.pbItem.Size = new System.Drawing.Size(228, 23);
            this.pbItem.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(532, 151);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 23;
            this.btnstart.Text = "시작";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // dmDept
            // 
            this.dmDept.Location = new System.Drawing.Point(502, 225);
            this.dmDept.Name = "dmDept";
            this.dmDept.Size = new System.Drawing.Size(120, 23);
            this.dmDept.TabIndex = 24;
            this.dmDept.Text = "dmupdown";
            // 
            // nmSales
            // 
            this.nmSales.Location = new System.Drawing.Point(502, 255);
            this.nmSales.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmSales.Name = "nmSales";
            this.nmSales.Size = new System.Drawing.Size(120, 23);
            this.nmSales.TabIndex = 25;
            // 
            // btnstep
            // 
            this.btnstep.Location = new System.Drawing.Point(379, 151);
            this.btnstep.Name = "btnstep";
            this.btnstep.Size = new System.Drawing.Size(75, 23);
            this.btnstep.TabIndex = 26;
            this.btnstep.Text = "step";
            this.btnstep.UseVisualStyleBackColor = true;
            this.btnstep.Click += new System.EventHandler(this.btnstep_Click);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(468, 311);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 23);
            this.dtStart.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 514);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.btnstep);
            this.Controls.Add(this.nmSales);
            this.Controls.Add(this.dmDept);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.pbItem);
            this.Controls.Add(this.hsbItem1);
            this.Controls.Add(this.cmb_item);
            this.Controls.Add(this.iconbox);
            this.Controls.Add(this.buttonbox);
            this.Controls.Add(this.bntContain);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.chkList);
            this.Controls.Add(this.resetbox);
            this.Controls.Add(this.div);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.min);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num2_text);
            this.Controls.Add(this.num1_text);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttonbox.ResumeLayout(false);
            this.buttonbox.PerformLayout();
            this.iconbox.ResumeLayout(false);
            this.iconbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox result_text;
        private TextBox num1_text;
        private TextBox num2_text;
        private Button add;
        private Button min;
        private Button mul;
        private Button div;
        private Button resetbox;
        private CheckedListBox chkList;
        private TextBox txtAdd;
        private Button btnAdd;
        private Button btnRemove;
        private Button bntContain;
        private GroupBox buttonbox;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox iconbox;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private ComboBox cmb_item;
        private HScrollBar hsbItem1;
        private ProgressBar pbItem;
        private System.Windows.Forms.Timer timer1;
        private Button btnstart;
        private DomainUpDown dmDept;
        private NumericUpDown nmSales;
        private Button btnstep;
        private DateTimePicker dtStart;
    }
}