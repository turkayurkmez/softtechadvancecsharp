namespace FormBagSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.InfoData = textBoxInfo.Text;
            form2.FormBag.IsActive = true;
            form2.FormBag.Image = pictureBox1.Image;
            form2.FormBag.Items = new List<string>() { "A", "B", "C" };
            form2.Show();


        }

        private void buttonUseExpando_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ExpandoObject.Message = "Expando, genel işlemlerin yapılabildiği DynamicObject nesnesidir";
            form2.ExpandoObject.Getir = new Action<string>(x => MessageBox.Show(x));
            form2.ExpandoObject.Topla = new Func<int, int, int>((a,b) => a + b);
            form2.Show();
        }
    }
}