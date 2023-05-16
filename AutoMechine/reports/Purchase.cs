
    internal class Purchase
    {
    public ProductType ProductType { get; set; }
    public DateTime DateTime { get; set; }
    public int Price { get; set; }
    public int MoneyReceived { get; set; }
    public int Change { get; set; }

  

    public string ToString()
    {
        return $"DateTime: {DateTime}, Product: {ProductType}, Price: {Price}, MoneyReceived: {MoneyReceived}, Change: {Change}";
    }

    }

