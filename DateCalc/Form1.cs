namespace DateCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DatePick_ValueChanged(object sender, EventArgs e)
        {
            datetxt.Text = "";
            DateTime today = DateTime.Today;
            DateTime day = DatePick.Value;
            if (today.Date == day.Date)
            {
                datetxt.Text = "1";
            }
            else if (today < day)
                MessageBox.Show("다시 선택하세요.");
            else
                datetxt.Text = (today.Subtract(day).Days + 2).ToString();
        }
    }
}