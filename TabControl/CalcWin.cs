using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class CalcWin : Form
    {
        public MyData myData;
        //private int dataVal = 0;
        //private string dataStr = "";
        //public int DataVal
        //{
        //    get { return dataVal; }

        //}
        //public string DataStr
        //{
        //    get { return dataStr; }

        //}
        public CalcWin()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int dataVal = 0;
            if (int.TryParse(txtData.Text, out dataVal))
            {
                //myData.dataVal = dataVal;
                //myData.dataStr = txtString.Text;
                myData = new MyData
                {
                    dataVal = dataVal,
                    dataStr = txtString.Text, 
                };
                Close();
            }
            else           
                MessageBox.Show("숫자입력");
            
            //try
            //{
            //    dataVal = int.Parse(txtData.Text);
            //}catch
            //{
            //    dataVal=0;
            //}
            //finally
            //{
            //    dataStr = txtString.Text;

            //}

            //    Close();
            //
        }

        private void CalcWin_Load(object sender, EventArgs e)
        {
            Form1 parent = (Form1)Owner;
            lblParents.Text = parent.parentSend;
        }
    }
}
