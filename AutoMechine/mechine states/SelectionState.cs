using AutoMechine;
internal class SelectionState : MechineState
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
    public override void PerformCurrentStateActions(Mechine form)
    {
        List<string> productList = new List<string>();
        for (int i = 0; i < form.Stock.StockDict.Count; i++)
        {
            if (form.Stock.StockDict[(ProductType)i].Count > 0)
            {
                productList.Add((ProductType)i + "  " + form.Stock.StockDict[(ProductType)i][0].Price.ToString());
            }
        }
        form.ComboBoxProducts.DataSource = productList;
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

