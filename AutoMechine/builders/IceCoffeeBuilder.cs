
    internal class IceCoffeeBuilder : DrinkBuilder
    {
    IceCoffee iceCoffee;
    public IceCoffeeBuilder(IceCoffee iceCoffee)
    {
        this.iceCoffee = iceCoffee;
    }
    public override void AddFlavorPowder()
    {
        iceCoffee.Description += "with nesCafe";
    }

    public override void PourMilk()
    {
        iceCoffee.Description += "and cold Milk";
    }

    public override void Mix()
    {
        //mixing the IceCoffee
    }

    public override void PourWater()
    {
        iceCoffee.Description += ", Ices cubes";
    }
    public override IceCoffee GetResult()
    {
        return iceCoffee;
    }

}

