using System.Threading;

namespace ParalelFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long totalSize = 0;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog()== DialogResult.OK)
            {
                string[] files = Directory.GetFiles(dialog.SelectedPath);
                Parallel.For(0, files.Length, index => {
                    FileInfo fileInfo = new FileInfo(files[index]);
                    long size = fileInfo.Length;
                    Interlocked.Add(ref totalSize, size);
                });
                label1.Text = $"{files.Length} adet dosyanın toplam boyutu: {totalSize}";
            }

          

        }
    }
}