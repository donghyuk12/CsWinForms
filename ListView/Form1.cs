namespace WinFormsTestApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "" || AgeTxt.Text == "" || JobTxt.Text == "")
                MessageBox.Show("빈 칸을 입력하세요.");
            else
            {
                listView1.Items.Add(new ListViewItem(new String[] { NameTxt.Text, AgeTxt.Text, JobTxt.Text }));
            }
            NameTxt.Clear();
            AgeTxt.Clear();
            JobTxt.Clear();

        }

        private void delbtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.RemoveAt(index);
            }
            catch (Exception exp)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }

        }

        private void rebtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "" || AgeTxt.Text == "" || JobTxt.Text == "")
            {
                MessageBox.Show("빈 칸을 입력하세요.");
                return;
            }
            try
            {
                listView1.SelectedItems[0].SubItems[0].Text = NameTxt.Text;
                listView1.SelectedItems[0].SubItems[0].Text = AgeTxt.Text;
                listView1.SelectedItems[0].SubItems[0].Text = JobTxt.Text;

            }catch(Exception exp)
            {
                MessageBox.Show("입력 항목 및 리스트 선택을 다시 살펴보세요.");
            }
            finally
            {
                NameTxt.Clear();
                AgeTxt.Clear();
                JobTxt.Clear();
            }
        }

        private void plbtn_Click(object sender, EventArgs e)
        {
            if (NameTxt.Text == "" || AgeTxt.Text == "" || JobTxt.Text == "")
            {
                MessageBox.Show("빈 칸을 입력하세요.");
                return;
            }
            try
            {
                int index = listView1.FocusedItem.Index;
                listView1.Items.Insert(index, new ListViewItem(new String[] { NameTxt.Text, AgeTxt.Text, JobTxt.Text }));
            }catch(Exception exp)
            {
                MessageBox.Show("리스트 항목을 다시 살펴보세요.");
            }
            finally
            {
                NameTxt.Clear();
                AgeTxt.Clear();
                JobTxt.Clear();
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1 != null)
            {
                int index = listView1.FocusedItem.Index;
                NameTxt.Enabled = false;
                NameTxt.Text = listView1.SelectedItems[index].SubItems[0].Text;
                AgeTxt.Text = listView1.SelectedItems[index].SubItems[1].Text;
                JobTxt.Text = listView1.SelectedItems[index].SubItems[2].Text;

            }
            else
                return;
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            NameTxt.Enabled = true;
            NameTxt.Text = "";
            AgeTxt.Text = "";
            JobTxt.Text = "";
        }
    }
}