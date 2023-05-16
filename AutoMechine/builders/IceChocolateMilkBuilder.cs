
    internal class IceChocolateMilkBuilder : DrinkBuilder
    {
    IceChocolateMilk iceChocolateMilk;
    public IceChocolateMilkBuilder(IceChocolateMilk chocolateMilk)
    {
        this.iceChocolateMilk = chocolateMilk;
    }
    public override void AddFlavorPowder()
    {
        iceChocolateMilk.Description += "with chocolit";
    }

    public override void PourMilk()
    {
        iceChocolateMilk.Description += "and skimmed milk";
    }

    public override void Mix()
    {
        //mixing the iceChocolateMilk
    }

    public override void PourWater()
    {
        iceChocolateMilk.Description += ",Ice cubes";
    }

    public override IceChocolateMilk GetResult()
    {
        return iceChocolateMilk;
    }
}

