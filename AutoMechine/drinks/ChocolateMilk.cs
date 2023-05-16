
    public class ChocolateMilk : Product
    {
    public ChocolateMilk(Product p) : base(p.Name, p.Price)
    {

    }
    public string Description { get; set; } = "";
    public override string ToString()
    {
        return base.ToString() +" "+ Description;
    }
}

