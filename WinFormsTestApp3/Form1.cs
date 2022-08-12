namespace WinFormsTestApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label1.Text = "(버튼 누름) 좌표 : " + e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label1.Text = "(버튼 놓음) 좌표 : " + e.Location;
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label2.Text = "(버튼 클릭) 좌표 : " + e.Location;
        }
     
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label2.Text = "(버튼 더블클릭) 좌표 : " + e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Text = e.Location.ToString();
        }

   
    }
}