
internal abstract class ProductDecorator : Product
{
    public Product Product { get; set; }
    public ProductDecorator(Product product):base(product.Name, product.Price)
    {
        this.Product = product;
    }
}

