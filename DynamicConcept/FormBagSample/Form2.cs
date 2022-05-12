using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBagSample
{
    public partial class Form2 : Form, IIncludeFormBag
    {
        public Form2()
        {
            InitializeComponent();
        }

        public dynamic FormBag { get; set; } = new FormBag();
        public dynamic ExpandoObject { get; set; } = new ExpandoObject();

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            labelInfo.Text = FormBag.InfoData;
            pictureBox1.Image = FormBag.Image;
            if (FormBag.IsActive)
            {
                MessageBox.Show("Form2 is active");
            }
            foreach (var item in FormBag.Items)
            {
                listBoxItems.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Text = ExpandoObject.Message;
            ExpandoObject.Getir("Bu mesaj, dinamik metod ile gönderildi");
            int result = ExpandoObject.Topla(3, 5);
            MessageBox.Show(result.ToString());
        }
    }
}
