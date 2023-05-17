using AutoMachine;
internal abstract class MachineState
    {
    public StateManager StateManager { get; set; }
    public abstract void ResetButtons(Machine machine);

    public abstract void PerformCurrentStateActions(Machine machine);

    }

