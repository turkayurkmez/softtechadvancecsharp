using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    public class CategoryService
    {
        //public delegate void CategoryAddedEventHandler(object sender, CategoryEventArgs e);
        public event EventHandler<CategoryEventArgs> CategoryAdded;

        public void AddCategory(Category category)
        {
            //db'ye eklendiğini varsayalım.....
            if (CategoryAdded != null)
            {
                var e = new CategoryEventArgs { Owner = "Türkay", Category = category, EventFiredDate = DateTime.Now };
                CategoryAdded(this, e);
            }


        }
    }
}
