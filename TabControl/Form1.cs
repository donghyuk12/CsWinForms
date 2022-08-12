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
    public partial class Form1 : Form
    {
        public string parentSend = "";
        public Form1()
        {
            InitializeComponent();
        }  

        private void tsmModalData_Click(object sender, EventArgs e)
        {
            parentSend = txtForm1.Text;
            CalcWin calModal = new CalcWin();
            calModal.Owner = this;
            DialogResult result = calModal.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtModalSend.Text = calModal.myData.dataVal.ToString();
                txtModalStr.Text = calModal.myData.dataStr.ToString(); 
            }
            calModal.Dispose();
        }

        private void TsmModalOpen_Click(object sender, EventArgs e)
        {
            ModalWindow mymodal = new ModalWindow();
            DialogResult result = mymodal.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("OK버튼");
            }
            else
                if (result == DialogResult.Yes)
            {
                MessageBox.Show("YES버튼");
            }
            else
                if (result == DialogResult.No)
            {
                MessageBox.Show("NO버튼");
            }
            mymodal.Dispose();
        }
    }
}
