using AutoMachine;
internal class PaymentState : MachineState
{
    private PaymentState(StateManager stateManager)
    {
        StateManager = stateManager;
    }

    private static PaymentState _instance;

    public static PaymentState GetInstance(StateManager stateManager)
    {
        if (_instance == null)
        {
            _instance = new PaymentState(stateManager);
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Machine Machine)
    {
        if (StateManager.Stock.StockDict[StateManager.ProductType].Count != 0)
        {
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            Machine.MoneyRecived.Text = $"Please insert {finalPrice}";
            if (Machine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            if (Machine.MoneyRecivedUpDoun.Value < finalPrice)
            {
                Machine.MoneyRecived.Text = $"Not Enough Money, Please add {finalPrice - Machine.MoneyRecivedUpDoun.Value}$";
            }
            else
            {
                Machine.Change.Text = $"change: {Machine.MoneyRecivedUpDoun.Value - finalPrice}";
                StateManager.ChangeState(ProcessState.GetInstance(StateManager));
                StateManager.PerformCurrentStateActions(Machine);
            }
        }
        else
        {
            Machine.MoneyRecived.Text = "Sorry, The product is out of stock!";
        }

    }

    public override void ResetButtons(Machine Machine)
    {
        Machine.ProductsLable.Hide();
        Machine.ComboBoxProducts.Hide();
        Machine.MoveToPaymentButton.Hide();
        Machine.BagCheckBox.Hide();
        Machine.GiftWrapCheckBox.Hide();
        Machine.BackButton.Show();
        Machine.PaymentButton.Show();
        int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
        if (Machine.GiftWrapCheckBox.Checked)
        {
            finalPrice += 2;
        }
        Machine.MoneyRecived.Text = $"Please insert {finalPrice}$";
        Machine.MoneyRecived.Show();
        Machine.MoneyRecivedUpDoun.Show();
        Machine.Change.Show();
        Machine.ProductLable.Hide();
    }
}

