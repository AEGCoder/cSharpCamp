
Product product1 = new Product();
            product1.Id = 1;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            System.Console.WriteLine(product1.ProductName);




             productManager.Topla2(5,9);

                int toplamaSonucu = productManager.Topla(44,16);
                System.Console.WriteLine(toplamaSonucu*2);
       
       
            