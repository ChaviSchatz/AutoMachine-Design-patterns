
    abstract class Report
    {
    public List<Purchase> PurchaseList { get; set; } = new();

    public void AddPurchase(Purchase purchase)
    {
        PurchaseList.Add(purchase);
    }

    }

