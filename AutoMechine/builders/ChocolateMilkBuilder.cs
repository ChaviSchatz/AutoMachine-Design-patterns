
    internal class ChocolateMilkBuilder : DrinkBuilder
    {
    ChocolateMilk chocolateMilk;
    public ChocolateMilkBuilder(ChocolateMilk chocolateMilk)
    {
        this.chocolateMilk = chocolateMilk;
    }
    public override void AddFlavorPowder()
    {
        chocolateMilk.Description += "with chocolit";
    }

    public override void PourMilk()
    {
        chocolateMilk.Description += "and skimmed milk";
    }

    public override void Mix()
    {
        //mixing the chocolateMilk
    }

    public override void PourWater()
    {
        chocolateMilk.Description += ",hot water";
    }
    public ChocolateMilk getResult()
    {
        return chocolateMilk;
    }

    public override Product GetResult()
    {
        return chocolateMilk;
    }
}

