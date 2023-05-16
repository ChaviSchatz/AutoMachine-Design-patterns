
abstract class Report
    {
    public TodaysPurchases TodaysPurchases { get; set; }

    public Report(TodaysPurchases todaysPurchases)
    {
        this.TodaysPurchases = todaysPurchases;
       
    }

    public abstract void WriteReport();
    public abstract void WriteReportTitle(TextWriter sr);
    public abstract void WriteReportContent(TextWriter sr);
    public abstract void WriteAdditionalCalculations(TextWriter sr);
    public abstract void WriteReportSummary(TextWriter sr);

}

