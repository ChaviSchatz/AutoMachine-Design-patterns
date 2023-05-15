
    internal class StateManager
    {

    public MechineState MechineState { get; set; }

    public ProductType ProductType { get; set; }

    public Stock Stock { get; set; }

    public StateManager(MechineState mechineState, ProductType productType, Stock stock)
    {
        this.MechineState = mechineState;
        MechineState.StateManager = this;
        this.ProductType = ProductType;
        this.Stock = stock;
    }

    public void ChangeState(MechineState nextState)
    {
        MechineState = nextState;
    }

    public void PerformCurrentStateActions()
    {
        MechineState.PerformCurrentStateActions();
    }
    public void ResetButtons()
    {
        MechineState.ResetButtons();
    }

}

