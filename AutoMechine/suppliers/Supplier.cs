
    abstract public class Supplier
    {
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    abstract public void OrderAProduct(int numForOrder, ProductType product);
    
    }

