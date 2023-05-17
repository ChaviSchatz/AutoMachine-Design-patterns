using System.Windows.Forms;
using System.Timers;
using Timer = System.Timers.Timer;
namespace AutoMachine
{
    internal partial class Machine : Form
    {
        private readonly Timer m_Timer;
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

        public Report ThisDayReport { get; set; }
        public Machine(Stock stock)
        {
            InitializeComponent();

            m_Timer = new Timer();
            m_Timer.Enabled = true;
            m_Timer.Interval = (10000 *60);
            m_Timer.Elapsed += ReportMaker;
            m_Timer.Start();

            TodaysPurchases = new TodaysPurchases();

            ProductsLable = productsLable;
            ComboBoxProducts = products;
            MoveToPaymentButton = MoveToPayment;
            BagCheckBox = bagCheckbox;
            GiftWrapCheckBox = giftWrapCheckBox;
            BackButton = backButton;
            MoneyRecived = moneyRecivedLable;
            MoneyRecivedUpDoun = moneyRecived;
            PaymentButton = paymentButton;
            Change = change;
            ProductLable = pruductLable;
            Stock = stock;

            StateManager = new(SelectionState.GetInstance(StateManager), Stock);
            StateManager.PerformCurrentStateActions(this);
        }

        private void MoveToPayment_Click(object sender, EventArgs e)
        {
            ProductsLable.Text = "Choose product: ";
            if (Stock.StockDict[(ProductType)ComboBoxProducts.SelectedIndex].Count > 0)
            {
                StateManager.ProductType = (ProductType)ComboBoxProducts.SelectedIndex;
                StateManager.ChangeState(PaymentState.GetInstance(StateManager));
                StateManager.ResetButtons(this);
            }
            else
            {
                ProductsLable.Text = "This product is out of Stock";
            }
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

        private void ReportMaker(object sender, ElapsedEventArgs args)
        {
            if (DateTime.Now.Hour == 0)
            {
                ThisDayReport = new TextReport(TodaysPurchases);
                ThisDayReport.WriteReport();
                TodaysPurchases = new TodaysPurchases();
            }
        }

        private void giftWrapCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void moneyRecived_ValueChanged(object sender, EventArgs e)
        {

        }
        private void products_SelectedIndexChanged(object sender, EventArgs e)
        {
            //StateManager.ProductType = 
        }
    }
}