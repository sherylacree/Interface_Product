namespace Interface_Product;

internal interface Program {

    static void Main(string[] args) {
        List<IProduct> products = new List<IProduct>();

        products.Add(new Vegetable { ProductName = "Carrot", ProductWeight = 2.00m, ProductPrice = 1.38m });
        products.Add(new Vegetable { ProductName = "Potato", ProductWeight = 3.50m, ProductPrice = 1.99m });
        products.Add(new Melons { ProductName = "Watermelon", ProductWeight = 5.000m, ProductPrice = 2.59m });
        products.Add(new Melons { ProductName = "Honeydew", ProductWeight = 2.500m, ProductPrice = 3.25m });
        products.Add(new Fruit { ProductName = "Cherries", ProductWeight = 5.000m, ProductPrice = 6.99m });
        products.Add(new Fruit { ProductName = "Orange", ProductWeight = 2.00m, ProductPrice = 4.99m });

        foreach (var product in products) {
            Console.WriteLine($"{product.ProductName}, Price:  {product.ProductPrice:C}, Weight:(lbs.oz) {product.ProductWeight}"); 
        }
    }
    
    

        
    }

