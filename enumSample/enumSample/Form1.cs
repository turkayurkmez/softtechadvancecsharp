namespace enumSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileSystemWatcher1.NotifyFilter = NotifyFilters.FileName | NotifyFilters.DirectoryName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Size | NotifyFilters.CreationTime | NotifyFilters.Attributes;

            MessageBox.Show(fileSystemWatcher1.NotifyFilter.ToString());
            switch (fileSystemWatcher1.NotifyFilter)
            {
                case NotifyFilters.FileName:
                    break;
                case NotifyFilters.DirectoryName:
                    break;
                case NotifyFilters.Attributes:
                    break;
                case NotifyFilters.Size:
                    break;
                case NotifyFilters.LastWrite:
                    break;
                case NotifyFilters.LastAccess:
                    break;
                case NotifyFilters.CreationTime:
                    break;
                case NotifyFilters.Security:
                    break;
                default:
                    break;
            }
        }
    }
}