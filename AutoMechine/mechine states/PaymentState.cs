using AutoMechine;
internal class PaymentState : MechineState
{
    private PaymentState() { }

    private static PaymentState _instance;

    public static PaymentState GetInstance()
    {
        if (_instance == null)
        {
            _instance = new PaymentState();
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Mechine form)
    {
        if (form.GiftWrapCheckBox.Checked)
        {
            
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

