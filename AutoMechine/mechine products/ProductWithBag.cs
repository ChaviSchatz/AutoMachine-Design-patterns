
internal class ProductWithBag : ProductDecorator
{
    public ProductWithBag(Product product) : base(product)
    {
    }

    public string ToString()
    {
        return base.ToString() + " with bag";
    }
}

