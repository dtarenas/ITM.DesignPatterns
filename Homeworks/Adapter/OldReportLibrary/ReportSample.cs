namespace Adapter.OldReportLibrary
{
    public class ReportSample
    {
        public void DoReport(IPaidReport paidReport)
        {
            var header = paidReport.GetHeader("Sample Header");
            var detail = paidReport.GetDetail("Sample detail information");
            var footer = paidReport.GetFooter("Sample footer");
            Console.WriteLine(paidReport.CreateReport(header, detail, footer));
        }
    }
}