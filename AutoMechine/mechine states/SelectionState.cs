using AutoMachine;
internal class SelectionState : MachineState
{
    private SelectionState(StateManager stateManager) {
        StateManager = stateManager;
    }

    private static SelectionState _instance;

    public static SelectionState GetInstance(StateManager stateManager)
    {
        if (_instance == null)
        {
            _instance = new SelectionState(stateManager);
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Machine Machine)
    {
        ResetButtons(Machine);
    }

    public override void ResetButtons(Machine Machine)
    {
        Machine.ProductsLable.Show();
        Machine.ComboBoxProducts.Show();
        Machine.MoveToPaymentButton.Show();
        Machine.BagCheckBox.Show();
        Machine.GiftWrapCheckBox.Show();
        Machine.BackButton.Hide();
        Machine.PaymentButton.Hide();
        Machine.MoneyRecived.Hide();
        Machine.MoneyRecivedUpDoun.Hide();
        Machine.Change.Hide();
        Machine.ProductLable.Hide();
    }
}

