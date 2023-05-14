
    internal class TextReportFactory : ReportFactory
    {
        internal override Report CreateReport()
        {
        return new TextReport();
        }
    }

