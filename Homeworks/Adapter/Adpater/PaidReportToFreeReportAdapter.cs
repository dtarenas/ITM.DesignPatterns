using Adapter.OldReportLibrary;

namespace Adapter.Adpater
{
    public class PaidReportToFreeReportAdapter : IPaidReport
    {
        private readonly FreeReport _freeReport;

        public PaidReportToFreeReportAdapter(FreeReport freeReport)
        {
            this._freeReport = freeReport;
        }

        public void CreateReport()
        {
            var reportContent = $"{this.GetHeader()}{Environment.NewLine}{this.GetDetail()}{Environment.NewLine}{this.GetFooter()}{Environment.NewLine}";
            Console.WriteLine(reportContent);
            _freeReport.
        }

        private string GetDetail()
        {
            return $"Free Report Detail Content {Guid.NewGuid()}";
        }

        private string GetFooter()
        {
            return $"Free Report Footer Content {Guid.NewGuid()}";
        }

        private string GetHeader()
        {
            return $"Free Report Header Content {Guid.NewGuid()}";
        }
    }
}
