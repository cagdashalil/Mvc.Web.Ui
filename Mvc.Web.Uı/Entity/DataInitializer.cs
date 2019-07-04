using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc.Web.Uı.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera", Description="Kamera ürünleri"},
                new Category(){Name="Bilgisayar", Description="Bilgisayar ürünleri"},
                new Category(){Name="Elektronik", Description="Elektronik ürünleri"},
                new Category(){Name="Telefon", Description="Telefon ürünleri"},
                new Category(){Name="Beyaz Eşya", Description="Beyaz Eşya ürünleri"}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }
            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name="Canon Eos 1200D 18-55 mm DC Profesyonel Dijital Fotoğraf Kamerası", Description="İş görür", Price=1400, Stock=50, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="Canon Eos 500 18-55 mm DC Profesyonel Dijital Fotoğraf Kamerası", Description="İş görür", Price=1200, Stock=200, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="Canon Eos 700 18-55 mm DC Profesyonel Dijital Fotoğraf Kamerası", Description="İş görür", Price=2300, Stock=500, IsApproved=false, CategoryId=1, IsHome=true},
                new Product(){Name="Canon Eos 150DX 18-55 mm DC Profesyonel Dijital Fotoğraf Kamerası", Description="İş görür", Price=4300, Stock=230, IsApproved=true, CategoryId=1, IsHome=true},
                new Product(){Name="Canon Eos 200 18-55 mm DC Profesyonel Dijital Fotoğraf Kamerası", Description="İş görür", Price=5200, Stock=100, IsApproved=true, CategoryId=1},

                new Product(){Name="Dell LATITUDE Dizüstü Bilgisayar", Description="İş görür", Price=2500, Stock=240, IsApproved=true, CategoryId=2, IsHome=true},
                new Product(){Name="Asus KXJ5050 Dizüstü Bilgisayar", Description="İş görür", Price=5000, Stock=200, IsApproved=false, CategoryId=2, IsHome=true},
                new Product(){Name="Dell LATITUDE Dizüstü Bilgisayar", Description="İş görür", Price=1500, Stock=100, IsApproved=true, CategoryId=2},
                new Product(){Name="Monster Dizüstü Bilgisayar", Description="İş görür", Price=2500, Stock=40, IsApproved=true, CategoryId=2, IsHome=true},
                new Product(){Name="Acer XKR33 Dizüstü Bilgisayar", Description="İş görür", Price=4500, Stock=70, IsApproved=false, CategoryId=2},

                new Product(){Name="Samsung XF LED TV", Description="İş görür", Price=2500, Stock=240, IsApproved=false, CategoryId=3, IsHome=true},
                new Product(){Name="Toshiba B450 LED TV", Description="İş görür", Price=5000, Stock=200, IsApproved=true, CategoryId=3},
                new Product(){Name="LG FD LED TV", Description="İş görür", Price=1500, Stock=100, IsApproved=false, CategoryId=3, IsHome=true},
                new Product(){Name="VESTEL LED TV", Description="İş görür", Price=2500, Stock=40, IsApproved=true, CategoryId=3, IsHome=true},
                new Product(){Name="Samsung A23 LED TV", Description="İş görür", Price=4500, Stock=70, IsApproved=true, CategoryId=3},

                new Product(){Name="Apple Iphone 6S Cep Telefon", Description="İş görür", Price=2500, Stock=240, IsApproved=true, CategoryId=4},
                new Product(){Name="Samsung J7 Cep Telefon", Description="İş görür", Price=5000, Stock=200, IsApproved=false, CategoryId=4, IsHome=true},
                new Product(){Name="Apple Iphone X Cep Telefon", Description="İş görür", Price=1500, Stock=100, IsApproved=true, CategoryId=4},
                new Product(){Name="Asus A Cep Telefon", Description="İş görür", Price=2500, Stock=40, IsApproved=false, CategoryId=4, IsHome=true},
                new Product(){Name="Apple Iphone 6 Cep Telefon", Description="İş görür", Price=4500, Stock=70, IsApproved=true, CategoryId=4, IsHome=true}
            };

            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}