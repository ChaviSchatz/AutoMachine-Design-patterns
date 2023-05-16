
    public class IceCoffee : Product
    {
    public string Description { get; set; } = "";
    public IceCoffee(Product p) : base(p.Name, p.Price)
    {

    }
    public override string ToString()
    {
        return base.ToString() + " " + Description;
    }
}

