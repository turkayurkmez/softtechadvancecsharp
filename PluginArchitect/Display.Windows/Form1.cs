using Display.SDK;

namespace Display.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pluginEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                List<Plug> plugList = Helper.GetPlugins(folderBrowserDialog.SelectedPath);
                plugList.ForEach(p =>
                {
                    ToolStripItem item = new ToolStripMenuItem(p.Name);
                    pluginsToolStripMenuItem.DropDownItems.Add(item);
                    item.Click += Item_Click;
                    loadedPlugins.Add(p.Name, p);
                });
            }

        }

        Dictionary<string, Plug> loadedPlugins = new Dictionary<string, Plug>();
        private void Item_Click(object? sender, EventArgs e)
        {
            string name = ((ToolStripItem)sender).Text;
            Plug plug = loadedPlugins[name];
            IPlug plugInstance = (IPlug)Helper.CreateInstance(plug);
            plugInstance.Draw(panel1.CreateGraphics(), new SolidBrush(buttonColor.BackColor), x, y, width, height);
        }

        int x;int y; int width; int height;
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
                x = int.Parse(textBoxX.Text);
                y = int.Parse(textBoxY.Text);
                width = int.Parse(textBoxWidth.Text);
                height = int.Parse(textBoxHeight.Text);
                


            }
        }
    }
}