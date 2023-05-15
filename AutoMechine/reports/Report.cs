
    abstract class Report
    {
    public TodaysPurchases TodaysPurchases { get; set; }
    public Report(TodaysPurchases todaysPurchases)
    {
        this.TodaysPurchases = todaysPurchases;
    }

    public abstract void WriteReport();

    }

