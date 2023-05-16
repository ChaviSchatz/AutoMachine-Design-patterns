
using AutoMechine;

internal class ProcessState : MechineState
{
    private ProcessState(StateManager stateManager) {
        StateManager = stateManager;
    }

    private static ProcessState _instance;

    public static ProcessState GetInstance(StateManager stateManager)
    {
        if (_instance == null)
        {
            _instance = new ProcessState(stateManager);
        }
        return _instance;
    }
    public override void PerformCurrentStateActions(Mechine form)
    {
        ResetButtons(form);
        Product product = StateManager.Stock.GetItem(StateManager.ProductType);
        DrinkMakar drinkMakar = new DrinkMakar();
        switch (StateManager.ProductType)
        {
            case ProductType.Coffee:
                Coffee coffee = new Coffee(product);
                CoffeeBuilder coffeeBuilder = new CoffeeBuilder(coffee);
                drinkMakar.MakeCoffee(coffeeBuilder);
                product = coffeeBuilder.GetResult();
                break;
            case ProductType.IceCoffee:
                IceCoffee iceCoffee = new IceCoffee(product);
                IceCoffeeBuilder iceCoffeeBuilder = new IceCoffeeBuilder(iceCoffee);
                drinkMakar.MakeIceCoffee(iceCoffeeBuilder);
                product = iceCoffeeBuilder.GetResult();
                break;
            case ProductType.ChocolateMilk:
                ChocolateMilk chocolateMilk = new ChocolateMilk(product);
                ChocolateMilkBuilder chocolateMilkBuilder = new ChocolateMilkBuilder(chocolateMilk);
                drinkMakar.MakeChocolateMilk(chocolateMilkBuilder);
                product = chocolateMilkBuilder.GetResult();
                break;
            case ProductType.IceChocolateMilk:
                IceChocolateMilk iceChocolateMilk = new IceChocolateMilk(product);
                IceChocolateMilkBuilder iceChocolateMilkBuilder = new IceChocolateMilkBuilder(iceChocolateMilk);
                drinkMakar.MakeIceChocolateMilk(iceChocolateMilkBuilder);
                product = iceChocolateMilkBuilder.GetResult();
                break;
            default:
                break;
        }

        if (form.GiftWrapCheckBox.Checked)
        {
            product = new ProductWithGiftWrap(product);
        }
        if (form.BagCheckBox.Checked)
        {
            product = new ProductWithBag(product);
        }
        form.ProductLable.Text = product.ToString();
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

