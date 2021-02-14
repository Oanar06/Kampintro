using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    { //ürünle ilgili operasyonlar var ekle sil güncelle listele....

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName+"eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
       
    }
}
