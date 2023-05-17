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
    public override void PerformCurrentStateActions(Machine machine)
    {
        if (StateManager.Stock.StockDict[StateManager.ProductType].Count != 0)
        {
            int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
            machine.MoneyRecived.Text = $"Please insert {finalPrice}";
            if (machine.GiftWrapCheckBox.Checked)
            {
                finalPrice += 2;
            }
            if (machine.MoneyRecivedUpDoun.Value < finalPrice)
            {
                machine.MoneyRecived.Text = $"Not Enough Money, Please add {finalPrice - machine.MoneyRecivedUpDoun.Value}$";
            }
            else
            {
                machine.Change.Text = $"change: {machine.MoneyRecivedUpDoun.Value - finalPrice}";
                StateManager.ChangeState(ProcessState.GetInstance(StateManager));
                StateManager.PerformCurrentStateActions(machine);
            }
        }
        else
        {
            machine.MoneyRecived.Text = "Sorry, The product is out of stock!";
        }

    }

    public override void ResetButtons(Machine machine)
    {
        machine.ProductsLable.Hide();
        machine.ComboBoxProducts.Hide();
        machine.MoveToPaymentButton.Hide();
        machine.BagCheckBox.Hide();
        machine.GiftWrapCheckBox.Hide();
        machine.BackButton.Show();
        machine.PaymentButton.Show();
        int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
        if (machine.GiftWrapCheckBox.Checked)
        {
            finalPrice += 2;
        }
        machine.MoneyRecived.Text = $"Please insert {finalPrice}$";
        machine.MoneyRecived.Show();
        machine.MoneyRecivedUpDoun.Value = 0;
        machine.MoneyRecivedUpDoun.Show();
        machine.Change.Show();
        machine.ProductLable.Hide();
    }
}

