using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //Ürün Id
        public int CategoryId { get; set; } // Hangi Kategori dahil olduğu 
        public string ProductName { get; set; } //ürünün ismi
        public double UnitPrice { get; set; } //Ürünün fiyatı
        public int UnitsInStock { get; set; } //Ürünün Stok Adedi

        //Crud operasyonlar
    }
}
