namespace FileSearchWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchBtn.Enabled = false;
            fileList.Items.Clear();

            FileSearch.File fileObj = new FileSearch.File();
            fileObj.sendFileName += sendFileName;
            Thread thread = new Thread(() =>
            {
                fileObj.Search(textDir.Text);
                this.Invoke(() => searchBtn.Enabled = true);
            });
            thread.Start();
        }

        private void sendFileName(string fileName)
        {
            if (fileList.InvokeRequired)
            {
                fileList.Invoke(() => fileList.Items.Add(fileName));
            }
            else
            {
                fileList.Items.Add(fileName);
            }
        }
    }
}
