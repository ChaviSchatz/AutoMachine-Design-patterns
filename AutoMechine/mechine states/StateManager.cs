using AutoMachine;
internal class StateManager
    {

    public MachineState MachineState { get; set; }

    public ProductType ProductType { get; set; }

    public Stock Stock { get; set; }

    public StateManager(MachineState MachineState, Stock stock)
    {
        this.MachineState = MachineState;
        MachineState.StateManager = this;
        this.Stock = stock;
    }

    public void ChangeState(MachineState nextState)
    {
        MachineState = nextState;
    }

    public void PerformCurrentStateActions(Machine machine)
    {
        MachineState.PerformCurrentStateActions(machine);
    }
    public void ResetButtons(Machine machine)
    {
        MachineState.ResetButtons(machine);
    }

}

