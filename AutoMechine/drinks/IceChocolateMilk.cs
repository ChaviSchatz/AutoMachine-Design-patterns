
    public class IceChocolateMilk : Product
    {
    public string Description { get; set; } = "";
    public string ToString()
    {
        return base.ToString + Description;
    }
}

