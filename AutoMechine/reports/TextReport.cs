


internal class TextReport : Report
    {

    public TextReport(TodaysPurchases todaysPurchases) : base(todaysPurchases)
        {


        }
        public override void WriteReport()
        {
            try
            {
                string dayOfWeek = DateTime.Now.DayOfWeek.ToString();
                TextWriter sr = new StreamWriter($"H:\\reports\\{dayOfWeek}.txt");
                WriteReportTitle(sr);
                WriteReportContent(sr);
                WriteAdditionalCalculations(sr);
                WriteReportSummary(sr);
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        public override void WriteReportTitle(TextWriter sr)
        {
            sr.WriteLine($"Daily Text report, date: {DateTime.Now}");
        }
        public override void WriteReportContent(TextWriter sr)
        {
            sr.WriteLine("content: ");
            foreach (Purchase s in TodaysPurchases.PurchaseList)
                sr.WriteLine(s.ToString());
        }
        public override void WriteAdditionalCalculations(TextWriter sr)
        {
            ///calculate////
        }
        public override void WriteReportSummary(TextWriter sr)
        {
            sr.WriteLine("end");
        }

}

