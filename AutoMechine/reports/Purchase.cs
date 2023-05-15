
    internal class Purchase
    {
    public ProductType ProductType { get; set; }
    public DateTime DateTime { get; set; }
    public double Price { get; set; }
    public double MoneyReceived { get; set; }
    public double Change { get; set; }

    public string ToString()
    {
        return $"DateTime: {DateTime}, Product: {ProductType}, Price: {Price}, MoneyReceived: {MoneyReceived}, Change: {Change}";
    }

    }

