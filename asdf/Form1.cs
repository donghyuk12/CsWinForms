namespace WinFormsTestApp2
{
    public partial class Form1 : Form
    {
        int MAX = 2;
        public Form1()
        {
            InitializeComponent();
        }

  
        //private void bntSave_Click(object sender, EventArgs e)
        //{
        //    //MessageBox.Show("작업예정");
        //    Form2 myform = new Form2();
        //    myform.ShowDialog();
        //}

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            string inputStr = txt_userInput.Text;
            //MessageBox.Show(txt_userInput.Text);
            if (inputStr.Length > MAX)
            {
                string strContain = "2";
                contain_txt.Text = inputStr.Contains(strContain).ToString();
                length_txt.Text = inputStr.Length.ToString();         
                substring_txt.Text = inputStr.Substring(0, inputStr.Length - MAX);
            }
            else
            {
                MessageBox.Show("substringError");
                contain_txt.Text = "-";
                length_txt.Text = "-";
                substring_txt.Text = "-";
                txt_userInput.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contain_txt.Text = "-";
            length_txt.Text = "-";
            substring_txt.Text = "-";
            txt_userInput.Text = "";
        }

        private void chk_Test1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckedChanged : " + chk_Test1.Checked + chk_Test1.CheckState);
        }

        private void chk_Test1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click : " + chk_Test1.Checked + chk_Test1.CheckState);
            chk_Test1.Checked = !chk_Test1.Checked;
        }

        private void chkListTest1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show("ItemCheck : " + chkListTest1.CheckedIndices.Count + " : " + chkListTest1.CheckedItems.Count);
        }

        private void chkListTest1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SelectedIndexChanged : " + chkListTest1.CheckedIndices.Count + " : " + chkListTest1.CheckedItems.Count);
        }

        private void cmbitemCombo_Click(object sender, EventArgs e)
        {
           
        }

        private void cmbitemCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("cmbitemCombo_Click : " + cmbitemCombo.Items[0].ToString());
        }
    }
}