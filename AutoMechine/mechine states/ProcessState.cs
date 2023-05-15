
using AutoMechine;

internal class ProcessState : MechineState
{
    private ProcessState() { }

    private static ProcessState _instance;

    public static ProcessState GetInstance()
    {
        if (_instance == null)
        {
            _instance = new ProcessState();
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Mechine form)
    {
        throw new NotImplementedException();
    }

    public override void ResetButtons(Mechine form)
    {
        form.ProductsLable.Hide();
        form.ComboBoxProducts.Hide();
        form.MoveToPaymentButton.Hide();
        form.BagCheckBox.Hide();
        form.GiftWrapCheckBox.Hide();
        form.BackButton.Hide();
        form.PaymentButton.Hide();
        form.MoneyRecived.Hide();
        form.MoneyRecivedUpDoun.Hide();
        form.Change.Show();
        form.ProductLable.Show();
    }
}

