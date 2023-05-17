
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
    public override void PerformCurrentStateActions(Machine machine)
    {
        ResetButtons(machine);
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

        if (machine.GiftWrapCheckBox.Checked)
        {
            product = new ProductWithGiftWrap(product);
        }
        if (machine.BagCheckBox.Checked)
        {
            product = new ProductWithBag(product);
        }
        machine.ProductLable.Text = product.ToString();

        Addpurchase(machine, product);

    }

    public override void ResetButtons(Machine machine)
    {
        machine.ProductsLable.Hide();
        machine.ComboBoxProducts.Hide();
        machine.MoveToPaymentButton.Hide();
        machine.BagCheckBox.Hide();
        machine.GiftWrapCheckBox.Hide();
        machine.BackButton.Show();
        machine.PaymentButton.Hide();
        machine.MoneyRecived.Hide();
        machine.MoneyRecivedUpDoun.Hide();
        machine.Change.Show();
        machine.ProductLable.Show();
    }

    private void Addpurchase(Machine machine, Product product)
    {
        Purchase p = new Purchase(StateManager.ProductType, DateTime.Now, product.Price,
            ((int)(machine.MoneyRecivedUpDoun.Value)),
            ((int)machine.MoneyRecivedUpDoun.Value - product.Price));
        machine.TodaysPurchases.AddPurchase(p);
    }


}

