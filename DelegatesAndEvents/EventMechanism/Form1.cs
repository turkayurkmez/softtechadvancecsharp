namespace EventMechanism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxSample_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBoxSample_MouseDown(object sender, MouseEventArgs e)
        {

        }
        CategoryService categoryService = new CategoryService();
        private void Form1_Load(object sender, EventArgs e)
        {

            categoryService.CategoryAdded += CategoryService_CategoryAdded;

        }

        private void CategoryService_CategoryAdded(object? sender, CategoryEventArgs e)
        {
            MessageBox.Show($"{e.Category.Name} kategorisi, {e.Owner} kullanıcısı tarafından {e.EventFiredDate} tarihinde eklendi.");
        }

        private void common_click(object sender, EventArgs e)
        {
            (sender as Button).BackColor = Color.Red;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            categoryService.AddCategory(new Category { Name = "Category 1", Id = 1 });
            categoryService.CategoryAdded -= CategoryService_CategoryAdded;
        }
    }
}