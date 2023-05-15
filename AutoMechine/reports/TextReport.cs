
internal class TextReport : Report
{
    public TextReport(TodaysPurchases todaysPurchases) : base(todaysPurchases)
    {

    }
    public override void WriteReport()
    {
        string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
        using (TextWriter tw = new StreamWriter($"\\.\\.\\reports\\{dayOfWeek}.txt"))
        {
            foreach (Purchase s in TodaysPurchases.PurchaseList)
                tw.WriteLine(s.ToString());
        }
    }

}

