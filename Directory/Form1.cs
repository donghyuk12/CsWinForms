using System.IO;

namespace Dirctory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDirList_Click(object sender, EventArgs e)
        {
            IbDir.Items.Clear();
            string[] direct = Directory.GetDirectories("C:\\Windows");
            foreach(string dir in direct)
                IbDir.Items.Add(dir);
        }

        private void btnFileList_Click(object sender, EventArgs e)
        {
            string[] dirfiles;
            string dir = IbDir.SelectedItem?.ToString() ?? string.Format(@"C:\\Windows");            
            if(null == IbDir.SelectedItem)
                dirfiles = Directory.GetFiles(@"C:\\Windows");
            else
            dirfiles = Directory.GetFiles(dir);
            
            IbFiles.Items.Clear();
            lvInfo.Items.Clear();
            MessageBox.Show($"{IbDir.SelectedItem}");
            foreach (var file in dirfiles)
            {
                FileInfo fi = new FileInfo(file);
                string info = string.Format("{0, -10}|{1, -10}|{2, 10}",fi.FullName, fi.Extension, fi.CreationTime);
                IbFiles.Items.Add(info);

                //ListViewItem listViewItem = new ListViewItem();
                //listViewItem.SubItems[0].
                //listViewItem.SubItems.Add(fi.Extension);
                //listViewItem.SubItems.Add(fi.CreationTime.ToString());
                lvInfo.Items.Add(new ListViewItem(new String[] { fi.Name, fi.Extension, fi.CreationTime.ToString() }));
            
            }
            
        }
    }
}