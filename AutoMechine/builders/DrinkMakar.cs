
    internal class DrinkMakar
    {
    public void MakeCoffee(CoffeeBuilder builder)
    {
        builder.AddFlavorPowder();
        builder.PourWater();
        builder.Mix();
        builder.PourMilk();
        builder.Mix();
    }
    public void MakeIceCoffee(IceCoffeeBuilder builder)
    {
        builder.AddFlavorPowder();
        builder.PourWater();
        builder.Mix();
        builder.PourMilk();
        builder.Mix();
    }
    public void MakeChocolateMilk(ChocolateMilkBuilder builder)
    {
        builder.AddFlavorPowder();
        builder.PourWater();
        builder.Mix();
        builder.PourMilk();
        builder.Mix();
    }
    public void MakeIceChocolateMilk(IceChocolateMilkBuilder builder)
    {
        builder.AddFlavorPowder();
        builder.PourWater();
        builder.Mix();
        builder.PourMilk();
        builder.Mix();
    }
}
