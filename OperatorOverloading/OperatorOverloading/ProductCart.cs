using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class ProductCart
    {
        private List<Product> products = new List<Product>();
        public void Add(Product product)
        {
            //foreach (var item in products)
            //{
            //    if (item == product)
            //    {

            //    }
            //}
            var existingProduct = products.Find(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                products.Add(product);
            }

            
        }

        public void Remove(Product product)
        {
            products.RemoveAll(p => p.Id == product.Id);
        }

        public double Total()
        {
            var result = 0.0;
            foreach (var product in products)
            {
                result += product;
            }
            return result;
        }

        public Product this[int id]
        {
            get { return products?.FirstOrDefault(p => p.Id == id); }
         
        }

        public Product this[string name]
        {
            get { return products?.FirstOrDefault(p => p.Name == name); }

        }

        public void ShowAll()
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        





    }
    
}
