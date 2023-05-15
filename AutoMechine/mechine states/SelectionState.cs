using AutoMechine;
internal class SelectionState : MechineState
{
    private SelectionState() { }

    private static SelectionState _instance;

    public static SelectionState GetInstance()
    {
        if (_instance == null)
        {
            _instance = new SelectionState();
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Mechine form)
    {
        ResetButtons(form);
    }

    public override void ResetButtons(Mechine form)
    {
        form.ProductsLable.Show();
        form.ComboBoxProducts.Show();
        form.MoveToPaymentButton.Show();
        form.BagCheckBox.Show();
        form.GiftWrapCheckBox.Show();
        form.BackButton.Hide();
        form.PaymentButton.Hide();
        form.MoneyRecived.Hide();
        form.MoneyRecivedUpDoun.Hide();
        form.Change.Hide();
        form.ProductLable.Hide();
    }
}

