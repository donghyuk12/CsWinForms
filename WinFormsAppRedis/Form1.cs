using StackExchange.Redis;
namespace WinFormsAppRedis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Redis redis = new Redis();
        private void RedisConnect_Click(object sender, EventArgs e)
        {
            RedisConnection();
        }
        private void RedisConnection()
        {
            
            if(redis.Init("127.0.0.1", 6379))
            {
                MessageBox.Show("Redis Connection OK");
            }
            else
            {
                MessageBox.Show("Redis Connection Fail");
            }
        }

        private void RedisSet_Click(object sender, EventArgs e)
        {
            SetStringData();
        }
        private void SetStringData()
        {
            
            string key = this.txt_key.Text;
            string val = this.txt_val.Text;
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("KEY ���� �Է��� �ּ���.");
                return;
            }
            if (string.IsNullOrEmpty(val))
            {
                MessageBox.Show("������ ���� �Է��� �ּ���.");
                return;
            }
            if(redis.SetString(this.txt_key.Text, this.txt_val.Text))
            {
                MessageBox.Show("������ �Ϸ� �Ǿ����ϴ�.");
            }
            else
            {
                MessageBox.Show("������ ���� �Ǿ����ϴ�.");
            }
            txt_val.Text = "";
            txt_key.Text = "";
        }

        private void RedisGet_Click(object sender, EventArgs e)
        {
            GetStringData();
        }
        private void GetStringData()
        {
            txt_val.Text = "";
            string key = this.txt_key.Text;
            
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("KEY ���� �Է��� �ּ���.");
                return ;
            }
            this.txt_result.Text = redis.GetString(key);
        }
    }
}