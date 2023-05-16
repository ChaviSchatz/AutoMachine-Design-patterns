
internal class ProductWithGiftWrap : ProductDecorator
{
    public ProductWithGiftWrap(Product product) : base(product)
    {
        product.Price += 2;
    }

    public override string ToString()
    {
        return Product.ToString() + " with gift wrap";
    }
}

