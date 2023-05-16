using System.Windows.Forms;

namespace AutoMechine
{
    internal partial class Mechine : Form
    {
        public TodaysPurchases TodaysPurchases { get; set; }

        public Stock Stock { get; set; }
        public StateManager StateManager { get; set; }
        public Label ProductsLable { get; set; }
        public ComboBox ComboBoxProducts { get; set; }
        public Button MoveToPaymentButton { get; set; }
        public CheckBox BagCheckBox { get; set; }
        public CheckBox GiftWrapCheckBox { get; set; }
        public Button BackButton { get; set; }
        public Button PaymentButton { get; set; }
        public Label MoneyRecived { get; set; }
        public NumericUpDown MoneyRecivedUpDoun { get; set; }
        public Label Change { get; set; }
        public Label ProductLable { get; set; }


        public Mechine(Stock stock)
        {
            InitializeComponent();
            TodaysPurchases = new TodaysPurchases();

            this.ProductsLable = productsLable;
            this.ComboBoxProducts = products;
            this.MoveToPaymentButton = MoveToPayment;
            this.BagCheckBox = bagCheckbox;
            this.GiftWrapCheckBox = giftWrapCheckBox;
            this.BackButton = backButton;
            this.MoneyRecived = moneyRecivedLable;
            this.MoneyRecivedUpDoun = moneyRecived;
            this.PaymentButton = paymentButton;
            this.Change = change;
            this.ProductLable = pruductLable;
            this.Stock = stock;

            this.StateManager = new(SelectionState.GetInstance(StateManager), Stock);

            StateManager.PerformCurrentStateActions(this);

            List<string> productList = new List<string>();
            for (int i = 0; i < Stock.StockDict.Count; i++)
            {
                if (Stock.StockDict[(ProductType)i].Count > 0)
                {
                    productList.Add((ProductType)i + "  " + Stock.StockDict[(ProductType)i][0].Price.ToString());
                }
            }
            ComboBoxProducts.DataSource = productList;

        }

        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StateManager.ProductType = 
        }

        private void MoveToPayment_Click(object sender, EventArgs e)
        {
            StateManager.ProductType = (ProductType)ComboBoxProducts.SelectedIndex;
            StateManager.ChangeState(PaymentState.GetInstance(StateManager));
            StateManager.ResetButtons(this);
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            StateManager.PerformCurrentStateActions(this);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StateManager.ChangeState(SelectionState.GetInstance(StateManager));
            StateManager.ResetButtons(this);
        }

        private void giftWrapCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void moneyRecived_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}