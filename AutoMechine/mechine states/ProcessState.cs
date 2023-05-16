
using AutoMachine;
using System.Windows.Forms;

internal class ProcessState : MachineState
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
    public override void PerformCurrentStateActions(Machine Machine)
    {
        ResetButtons(Machine);
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

        if (Machine.GiftWrapCheckBox.Checked)
        {
            product = new ProductWithGiftWrap(product);
        }
        if (Machine.BagCheckBox.Checked)
        {
            product = new ProductWithBag(product);
        }
        Machine.ProductLable.Text = product.ToString();

        Addpurchase(Machine, product);

    }

    public override void ResetButtons(Machine Machine)
    {
        Machine.ProductsLable.Hide();
        Machine.ComboBoxProducts.Hide();
        Machine.MoveToPaymentButton.Hide();
        Machine.BagCheckBox.Hide();
        Machine.GiftWrapCheckBox.Hide();
        Machine.BackButton.Show();
        Machine.PaymentButton.Hide();
        Machine.MoneyRecived.Hide();
        Machine.MoneyRecivedUpDoun.Hide();
        Machine.Change.Show();
        Machine.ProductLable.Show();
    }

    private void Addpurchase(Machine Machine, Product product)
    {
        Purchase p = new Purchase(StateManager.ProductType, DateTime.Now, product.Price,
            ((int)(Machine.MoneyRecivedUpDoun.Value)),
            ((int)Machine.MoneyRecivedUpDoun.Value - product.Price));
        Machine.TodaysPurchases.AddPurchase(p);
    }


}

