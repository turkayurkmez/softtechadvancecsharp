namespace usingTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }

        private async void button1_Click(object sender, EventArgs e)
        {

           // loop();
           

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://www.google.com");
            MessageBox.Show("Google'dan veri çekildi");
            //if (response.IsCompleted)
            //{
                richTextBox1.Text = response.Content.ReadAsStringAsync().Result;
            //}
            
        }

        async Task loop()
        {
            await Task.Run(() =>
             {
                 for (int i = 0; i < 100000; i++)
                 {
                     label1.Text = i.ToString();
                 }
             });

        }
    }
}