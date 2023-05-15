namespace AutoMechine
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            List<Product> coffees = new List<Product>();
            for (int i = 0; i < 10; i++) { coffees.Add(new Product() { Name = "coffee", Price = 8 }); }

            List<Product> iceCoffees = new List<Product>();
            for (int i = 0; i < 10; i++) { iceCoffees.Add(new Product() { Name = "iceCoffees", Price = 15 }); }

            List<Product> iceChocolateMilk = new List<Product>();
            for (int i = 0; i < 10; i++) { iceChocolateMilk.Add(new Product() { Name = "iceChocolate", Price = 18 }); }

            List<Product> ChocolateMilk = new List<Product>();
            for (int i = 0; i < 10; i++) { ChocolateMilk.Add(new Product() { Name = "ChocolateMilk", Price = 12 }); }

            List<Product> MilkMunch = new List<Product>();
            for (int i = 0; i < 10; i++) { MilkMunch.Add(new Product() { Name = "MilkMunch", Price = 6 }); }

            List<Product> KitKat = new List<Product>(); 
            for (int i = 0; i < 10; i++) { KitKat.Add(new Product() { Name = "KitKat", Price = 3 }); }

            List<Product> MAndM = new List<Product>();
            for (int i = 0; i < 10; i++) { MAndM.Add(new Product() { Name = "MAndM", Price = 10 }); }

            List<Product> Pringles = new List<Product>();
            for (int i = 0; i < 10; i++) { Pringles.Add(new Product() { Name = "Pringles", Price = 13 }); }

            Dictionary<ProductType, List<Product>> products = new();
            products.Add(ProductType.Coffee, coffees);
            products.Add(ProductType.ChocolateMilk, ChocolateMilk);
            products.Add(ProductType.IceChocolateMilk, iceChocolateMilk);
            products.Add(ProductType.IceCoffee, iceCoffees);
            products.Add(ProductType.KitKat, KitKat);
            products.Add(ProductType.MAndM, MAndM);
            products.Add(ProductType.MilkMunch, MilkMunch);
            products.Add(ProductType.Pringles, Pringles);

            Unilever unilever = new Unilever("jo", "0556721941");
            Tnuva tnuva  = new Tnuva("gil", "0589576854");

            Dictionary<ProductType, Supplier> stockSuppliers = new();
            stockSuppliers.Add(ProductType.Coffee, tnuva);
            stockSuppliers.Add(ProductType.ChocolateMilk, tnuva);
            stockSuppliers.Add(ProductType.IceChocolateMilk, tnuva);
            stockSuppliers.Add(ProductType.IceCoffee, tnuva);
            stockSuppliers.Add(ProductType.KitKat, unilever);
            stockSuppliers.Add(ProductType.MAndM, unilever);
            stockSuppliers.Add(ProductType.MilkMunch, unilever);
            stockSuppliers.Add(ProductType.Pringles, unilever);

            Stock allStock = new Stock(products, stockSuppliers);
            Mechine mechine1 = new Mechine(allStock);
            Mechine mechine2 = new Mechine(allStock);
            Mechine mechine3 = new Mechine(allStock);

            Application.Run(mechine1);
        }
    }
}