
internal class ProductWithGiftWrap : ProductDecorator
{
    public ProductWithGiftWrap(Product product) : base(product)
    {
        product.Price += 2;
    }

    public string ToString()
    {
        return base.ToString() + " with gift wrap";
    }
}

