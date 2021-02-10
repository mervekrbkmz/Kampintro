using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
   public class Product //bu culasslarda sadece özellik olur.
    {
        //snippet:hazır kodlar taba basmak.
        //OOP
        public int Id { get; set; }//primary key(özel)
        public int CategoryId { get; set; }//foreign key referans  //ürünleri hangi kategoride tutmak için.referans alanları(foreign key)
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }//stok adedi.
        //CRUD OPERASYONU: CREAT,READ,UPDATE,DELETE

    }
}
