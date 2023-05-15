
    internal abstract class MechineState
    {
    public StateManager StateManager { get; set; }
    public abstract void ResetButtons();

    public abstract void PerformCurrentStateActions();

    }

