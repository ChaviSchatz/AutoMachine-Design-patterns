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
    public override void PerformCurrentStateActions(Machine machine)
    {
        ResetButtons(machine);
    }

    public override void ResetButtons(Machine machine)
    {
        List<string> productList = new List<string>();
        for (int i = 0; i < machine.Stock.StockDict.Count; i++)
        {
            if (machine.Stock.StockDict[(ProductType)i].Count > 0)
            {
                productList.Add((ProductType)i + "  " + machine.Stock.StockDict[(ProductType)i][0].Price.ToString());
            }
            else
            {
                productList.Add((ProductType)i + "   not in stock");
            }
        }
        machine.ComboBoxProducts.DataSource = productList;
        machine.ProductsLable.Show();
        machine.ComboBoxProducts.Show();
        machine.MoveToPaymentButton.Show();
        machine.BagCheckBox.Show();
        machine.GiftWrapCheckBox.Show();
        machine.BackButton.Hide();
        machine.PaymentButton.Hide();
        machine.MoneyRecived.Hide();
        machine.MoneyRecivedUpDoun.Hide();
        machine.Change.Hide();
        machine.ProductLable.Hide();
    }
}

