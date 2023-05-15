
    abstract public class Supplier
    {
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public Supplier(string name, string phoneNumber)
    {
        this.Name = name;
        this.PhoneNumber = phoneNumber;
    }
    abstract public void OrderAProduct(int numForOrder, ProductType product);
    
    }

