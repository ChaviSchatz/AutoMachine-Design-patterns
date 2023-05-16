using AutoMechine;
internal class PaymentState : MechineState
{
    private PaymentState(StateManager stateManager) { 
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
    public override void PerformCurrentStateActions(Mechine form)
    {
        int finalPrice = StateManager.Stock.StockDict[StateManager.ProductType][0].Price;
        if (form.GiftWrapCheckBox.Checked)
        {
            finalPrice += 2;
        }
        if(form.MoneyRecivedUpDoun.Value < finalPrice)
        {
            form.MoneyRecived.Text = $"Not Enough Money, Please add {finalPrice - form.MoneyRecivedUpDoun.Value}$";
        }
        else
        {
            form.Change.Text += $"{form.MoneyRecivedUpDoun.Value - finalPrice}";
            StateManager.ChangeState(ProcessState.GetInstance(StateManager));
            StateManager.PerformCurrentStateActions(form);
        }


    }

    public override void ResetButtons(Mechine form)
    {
        form.ProductsLable.Hide();
        form.ComboBoxProducts.Hide();
        form.MoveToPaymentButton.Hide();
        form.BagCheckBox.Hide();
        form.GiftWrapCheckBox.Hide();
        form.BackButton.Show();
        form.PaymentButton.Show();
        form.MoneyRecived.Show();
        form.MoneyRecivedUpDoun.Show();
        form.Change.Show();
        form.ProductLable.Hide();
    }
}

