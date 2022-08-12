using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace MysqlDirctory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            char c = 'A';
            while (c <= 'Z')
            {
                StrStart.Items.Add(c);
                c++;
            }
        }
        private void listView_ColumnSizeAutoChange(ListView LV)
        {
            for (int i = 0; i < LV.Columns.Count; i++)
            {
                LV.Columns[i].Width = -2;
            }
        }
        private void quiry_Click(object sender, EventArgs e)
        {
            lstView.Items.Clear();
            if (StrStart.SelectedItem == null)
            {
                MessageBox.Show("값을 선택하세요.");
            }
            else
            {
                string host = "localhost";
                int port = 3306;
                string database = "world";
                string uid = "root";
                string pwd = "1234";
                string connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {

                    //try
                    //{
                    //    connection.Open();
                    //    MessageBox.Show("Connected");
                    //    string sql = "SELECT * FROM country";
                    //    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    //    MySqlDataReader table = cmd.ExecuteReader();
                    //    while (table.Read())
                    //    {
                    //        string[] str = { table["code"].ToString() };
                    //        string[] dir = { string.Format("{0,4}", table["code"]), String.Format("{0,-20}", table["name"]), string.Format("{0,20:N0} 명", table["population"]) };
                    //        ListViewItem item = new ListViewItem(dir);
                    //        if (str[0].IndexOf(StrStart.SelectedItem.ToString(), 0, str[0].Length) == 0)
                    //        {
                    //            lstView.Items.Add(item);
                    //        }
                    //    }

                    //    table.Close();
                    //}
                    try
                    {
                        connection.Open();
                        MessageBox.Show("Connected");
                        string sql = string.Format("SELECT * FROM country where code like CONCAT('{0}', '%')", StrStart.Text);
                        MySqlCommand cmd = new MySqlCommand(sql, connection);
                        MySqlDataReader table = cmd.ExecuteReader();
                        while (table.Read())
                        {
                            lstView.Items.Add(new ListViewItem(new String[] { string.Format("{0,-4}", table["code"]), 
                                String.Format("{0,-20}", table["name"]), string.Format("{0:N0} 명", table["population"])}));
                        }
                        table.Close();
                        listView_ColumnSizeAutoChange(lstView);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("Connection fail\n" + exp.ToString());
                    }
                    connection.Close();

                }
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            
            string host = "localhost";
            int port = 3306;
            string database = "world";
            string uid = "root";
            string pwd = "1234";
            string connStr = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", host, port, database, uid, pwd);
            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connected");
                    string sql = string.Format("UPDATE country SET name = '{0}' WHERE CODE = '{1}'", txtSelect.Text.Trim(), txtHidden.Text.Trim());
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    if (cmd.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("수행건이 없습니다.");
                    }
                    else
                    {
                        MessageBox.Show("수정하였습니다.");
                    }
                    listView_ColumnSizeAutoChange(lstView);
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Connection fail\n" + exp.ToString());
                }
                connection.Close();
            }
            txtSelect.Text = "";
        }

        private void lstView_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtHidden.Text = ((ListView)sender).FocusedItem.SubItems[0].Text;
            txtSelect.Text = ((ListView)sender).FocusedItem.SubItems[1].Text;

        }
    }
}
