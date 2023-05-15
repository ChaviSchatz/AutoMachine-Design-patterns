
     internal class ReportFactory
    {
    public Report CreateReport(ReportFormat format, TodaysPurchases todaysPurchases)
    {
        switch (format)
        {
            case ReportFormat.Txt:
                return new TextReport(todaysPurchases);
            default:
              return null;
        }
    }
        
    }

