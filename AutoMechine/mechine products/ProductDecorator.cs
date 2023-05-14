
internal abstract class ProductDecorator : Product
{
    public Product Product { get; set; }
    public ProductDecorator(Product product)
    {
        this.Product = product;
    }
}

