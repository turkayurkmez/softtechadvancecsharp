namespace introThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread;
        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(forLoop));
            thread.Start();
        }

        void forLoop()
        {
            for (int i = 0; i <= 100000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 1000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tıklandı");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //thread.Suspend();
        }
    }
}