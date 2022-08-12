using System.IO;
using System.Text;

namespace WinFormsTestApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte[] data = new byte[26];
        char[] chars = new char[26];
        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\UTIL\test.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter fw = new StreamWriter(fs);
            BinaryWriter bw = new BinaryWriter(fs);
            
            //for(int i = 0; i < data.Length; i++)
            //{
            //    data[i] = (byte)(65 + i);    
              
            //}
            //fs.Write(data, 0, data.Length);
            //fw.Write(txtContent.Text);
            bw.Write(txtContent.Text);
            //fs.Close();
            //fw.Close();
            bw.Close();
            MessageBox.Show("파일에 입력했습니다.");
            txtContent.Text = "";

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            txtContent.Text = "";
            FileStream fs = new FileStream(@"C:\UTIL\test.txt", FileMode.Open, FileAccess.Read);
            //fs.Read(data, 0, data.Length);
            //fs.Close();
            //StringBuilder sb = new StringBuilder();
            //foreach (var item in data)
            //{
            //    sb.Append(item.ToString()+", ");

            //    //txtContent.Text += item.ToString() + ",";               
            //}
            BinaryReader br = new BinaryReader(fs);
            //StreamReader fr = new StreamReader(fs);
            //txtContent.Text = fr.ReadToEnd();
            txtContent.Text = br.ReadString();

            br.Close();
            //fr.Close();
            //txtContent.Text = sb.ToString();
       
        }
    }
}