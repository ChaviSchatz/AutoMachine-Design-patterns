 
public class Stock
    {
    private const int NUMFORORDER = 10;
    public Dictionary<ProductType, List<Product>> StockDict { get; }
    private Dictionary<ProductType, Supplier> StockSuplliers { get; }

    public Stock(Dictionary<ProductType, List<Product>> stockDict, Dictionary<ProductType, Supplier> stockSuplliers)
    {
        StockDict = stockDict;
        StockSuplliers = stockSuplliers;
    }
    public Product GetItem(ProductType productType)
    {
        Product product = null;
        if (StockDict.ContainsKey(productType))
        {
            if(StockDict[productType].Count > 0)
            {
                product = StockDict[productType][0];
                StockDict[productType].RemoveAt(0);
            }
            if (StockDict[productType].Count == 5)
            {
                UpdateSupplier(productType, NUMFORORDER);
            }
        }
        return product;
    }

    private void UpdateSupplier(ProductType productType, int numToOrder)
    {
        StockSuplliers[productType].OrderAProduct(numToOrder, productType);
    }

    public void AddProductsToStock(ProductType productType,  List<Product> products)
    {
        products.ForEach(p =>
        {
            StockDict[productType].Add(p);
        });
    }

    }

