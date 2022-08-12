namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void num1_TextChanged(object sender, EventArgs e)
        {

        }
        private void num2_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calculate(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show(sender.ToString());
                var btnText = ((Button)sender).Text;
                result_text.Enabled = true;
                double result1 = double.Parse(num1_text.Text);
                double result2 = double.Parse(num2_text.Text);
                double result = 0.0;
                switch (btnText)
                {
                    case "+":
                        result = result1 + result2;
                        result_text.Text = Convert.ToString(result);
                        result_text.Enabled = true;
                        break;
                    case "-":
                        result = result1 - result2;
                        result_text.Text = Convert.ToString(result);
                        result_text.Enabled = true;
                        break;
                    case "*":
                        result = result1 * result2;
                        result_text.Text = Convert.ToString(result);
                        result_text.Enabled = true;
                        break;
                    case "/":
                        if (result2 == 0)
                        {
                            result_text.Text = "0���� ���� �� �����ϴ�.";
                            result_text.Enabled = true;
                            break;
                        }
                        result = result1 / result2;
                        result_text.Text = Convert.ToString(result);
                        result_text.Enabled = true;
                        break;    
                }
            }
            catch (FormatException)
            {
                result_text.Text = "�ùٸ� ���� �Է��ϼ���.";
            }



            }

        //private void add_Click(object sender, EventArgs e)
        //{
        //    try
        //    {            
        //        double num1 = double.Parse(num1_text.Text);
        //        double num2 = double.Parse(num2_text.Text);
        //        double result = num1 + num2;
        //        result_text.Text = Convert.ToString(result);
        //        result_text.Enabled = true;
        //    }
        //    catch (FormatException)
        //    {
        //        result_text.Text = "�ùٸ� ���� �Է��ϼ���.";
        //    }
        //}

        //private void min_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        double num1 = double.Parse(num1_text.Text);
        //        double num2 = double.Parse(num2_text.Text);
        //        double result = num1 - num2;
        //        result_text.Text = Convert.ToString(result);
        //        result_text.Enabled = true;
        //    }
        //    catch (FormatException)
        //    {
        //        result_text.Text = "�ùٸ� ���� �Է��ϼ���.";
        //    }
        //}
        //private void mul_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        double num1 = double.Parse(num1_text.Text);
        //        double num2 = double.Parse(num2_text.Text);
        //        double result = num1 * num2;
        //        result_text.Text = Convert.ToString(result);
        //        result_text.Enabled = true;
        //    }
        //    catch (FormatException)
        //    {
        //        result_text.Text = "�ùٸ� ���� �Է��ϼ���.";
        //    }
        //}

        //private void div_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        double num1 = double.Parse(num1_text.Text);
        //        double num2 = double.Parse(num2_text.Text);
        //        if (num2 == 0)
        //        {
        //            result_text.Text = "0���� ���� �� �����ϴ�.";
        //        }
        //        else
        //        {
        //            double result = num1 / num2;
        //            result_text.Text = Convert.ToString(result);
        //            result_text.Enabled = true;
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        result_text.Text = "�ùٸ� ���� �Է��ϼ���.";
        //    }


        //}

        private void resetbox_Click(object sender, EventArgs e)
        {
            result_text.Text ="";
            num1_text.Text = "";
            num2_text.Text = "";
            result_text.Enabled = false;
        }

        private void result_text_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBoxButtons mbb = MessageBoxButtons.YesNoCancel;
            MessageBoxIcon mbi = MessageBoxIcon.Asterisk;

            if (e.KeyCode == Keys.A && e.Shift && e.Control)
                MessageBox.Show($"{e.KeyCode}+Shift+Control");

            //else
            //MessageBox.Show("KeyDown:���Ű : "+e.Modifiers.ToString(), "Down", mbb, mbi);
        }

        private void result_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("KeyPress:����Ű", "Press", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
        }  
        private void Form1_Load(object sender, EventArgs e)
        {
            var itemArr = new string[] { "�׸�1", "�׸�2", "�׸�3", "�׸�4", "�׸�5", "�׸�6", "�׸�7", };
            chkList.Items.Clear();
            cmb_item.Items.Clear();
            dmDept.Items.Clear();
            foreach (var item in itemArr)
            {
                chkList.Items.Add(item);
                cmb_item.Items.Add(item);
                dmDept.Items.Add(item);
            }
                    
            cmb_item.SelectedIndex = 0;
            hsbItem1.Value = 0;
            dmDept.SelectedIndex = 0;
            dtStart.Format = DateTimePickerFormat.Time;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var txtStr = txtAdd.Text;
            chkList.Items.Add(txtStr);
            txtAdd.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var itemCount = chkList.Items.Count - 1;
            if (itemCount < 0)
                MessageBox.Show("�׸��� ������ϴ�.");
            else

                chkList.Items.RemoveAt(itemCount);
        }

        private void bntContain_Click(object sender, EventArgs e)
        {
            var itemCount = chkList.Items.Count - 1;
            if (itemCount < 0)
                MessageBox.Show("�׸��� ������ϴ�.");
            else 
            {              
                for (int i = 0; i <itemCount; i++)
                {
                    var item = chkList.Items[i];
                    if (item.ToString() == txtAdd.Text)
                    {
                        chkList.Items.Remove(chkList.Items[i]);
                    }                    
                }                                                   
            }
        }

        private void hsbItem1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if(pbItem.Value == pbItem.Maximum)
            {               
                timer1.Stop();               
                btnstart.Enabled = true;
                if (btnstart.Enabled == true) MessageBox.Show("�Ϸ�");
            }
            else
            pbItem.Value++;
            
        }

        private void btnstart_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            btnstart.Enabled = false;
            pbItem.Value = pbItem.Minimum;
            timer1.Start();
        }

        private void btnstep_Click(object sender, EventArgs e)
        {
            pbItem.PerformStep();
        }
    }
}