namespace WinFormsTestApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntshow_Click(object sender, EventArgs e)
        {
            MessageBoxButtons mbt = MessageBoxButtons.OK;
            MessageBoxIcon mbi=MessageBoxIcon.None;
            if(rbOK.Checked)
                mbt = MessageBoxButtons.OK;
            else if(radioButton2.Checked)
                mbt= MessageBoxButtons.OKCancel;
            else if (radioButton3.Checked)
                mbt = MessageBoxButtons.AbortRetryIgnore;
            else if (radioButton4.Checked)
                mbt = MessageBoxButtons.YesNoCancel;
            else if (radioButton5.Checked)
                mbt = MessageBoxButtons.YesNo;
            else if (radioButton6.Checked)
                mbt = MessageBoxButtons.RetryCancel;
            else
                mbt = MessageBoxButtons.CancelTryContinue;

            if(radioButton7.Checked)
                mbi = MessageBoxIcon.None;
            else if(radioButton8.Checked)
                mbi= MessageBoxIcon.Hand;
            else if (radioButton9.Checked)
                mbi = MessageBoxIcon.Stop;
            else if (radioButton10.Checked)
                mbi = MessageBoxIcon.Error;
            else if (radioButton11.Checked)
                mbi = MessageBoxIcon.Question;
            else if (radioButton12.Checked)
                mbi = MessageBoxIcon.Exclamation;
            else if (radioButton13.Checked)
                mbi = MessageBoxIcon.Warning;
            else if (radioButton14.Checked)
                mbi = MessageBoxIcon.Asterisk;
            else
                mbi = MessageBoxIcon.Information;

            MessageBox.Show("", "",mbt,mbi);
        }
    }
    
}