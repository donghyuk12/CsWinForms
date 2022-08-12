namespace WinFormsTestApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cLstBox.Items.Clear();
            string[] items = { "1", "2", "3", "임", "dla"};
            foreach (var item in items)
            {
                cLstBox.Items.Add(item);
            }
        }

        private void smoveRight_Click(object sender, EventArgs e)
        {
            try
            {
                lstBox.Items.Add(cLstBox.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("체크 다시");
            }
           
            
        }

        private void amoveRight_Click(object sender, EventArgs e)
        {
            foreach (var item in cLstBox.Items)
            {
                lstBox.Items.Add(item.ToString());
            }
            
        } 
        private void delbtn_Click(object sender, EventArgs e)
        {
            lstBox.Items.Clear();
        }

        private void smoveLeft_Click(object sender, EventArgs e)
        {
            
            try
            {
                List<string> lstRemove = new List<string>();
                //cLstBox.Items.Add(lstBox.SelectedItem.ToString());
                foreach (string item in lstBox.SelectedItems)
                {
                    lstRemove.Add(item);
                }
                foreach (var item in lstRemove)
                {
                    lstBox.Items.Remove(item);
                    }
               
            }
            catch (Exception)
            {
                MessageBox.Show("체크를 다시");
            }
            
        }
    }
}