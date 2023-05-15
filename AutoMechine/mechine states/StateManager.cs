using AutoMechine;
internal class StateManager
    {

    public MechineState MechineState { get; set; }

    public ProductType ProductType { get; set; }

    public Stock Stock { get; set; }

    public StateManager(MechineState mechineState, Stock stock)
    {
        this.MechineState = mechineState;
        MechineState.StateManager = this;
        this.Stock = stock;
    }

    public void ChangeState(MechineState nextState)
    {
        MechineState = nextState;
    }

    public void PerformCurrentStateActions(Mechine form)
    {
        MechineState.PerformCurrentStateActions(form);
    }
    public void ResetButtons(Mechine form)
    {
        MechineState.ResetButtons(form);
    }

}

