
internal class CoffeeBuilder : DrinkBuilder
{
    Coffee coffee;
    public CoffeeBuilder(Coffee coffee)
    {
       this.coffee = coffee;    
    }
    public override void AddFlavorPowder()
    {
        coffee.Description += "with nesCafe";
    }

    public override void PourMilk()
    {
        coffee.Description += "and skimmed milk";
    }

    public override void Mix()
    {
        //mixing the coffee
    }

    public override void PourWater()
    {
        coffee.Description += ",hot water";
    }
    public Coffee getResult()
    {
        return coffee;
    }

    public override Product GetResult()
    {
        return coffee;
    }
}


