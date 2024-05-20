using Adapter.ExistingApp;

namespace Adapter.Adpater
{
    public class FreeReportLibraryReportToNewReportLibraryAdapter : IFreeReportLibrary
    {
        private readonly NewReportLibrary _newReportLibrary;

        public FreeReportLibraryReportToNewReportLibraryAdapter(NewReportLibrary freeReport)
        {
            this._newReportLibrary = freeReport;
        }

        public void AddDetails(List<string> details)
        {
            var groupDetail = _newReportLibrary.CreateGroupDetail();
            var textValue = string.Join("\n", details);
            _newReportLibrary.AddText(groupDetail, textValue);
        }

        public void AddFooter(string footer)
        {
            var groupFooter = _newReportLibrary.CreateGroupFooter();
            _newReportLibrary.AddText(groupFooter, footer);
        }

        public void AddHeader(string header)
        {
            var groupHeader = _newReportLibrary.CreateGroupHeader();
            _newReportLibrary.AddText(groupHeader, header);
        }

        public string CreateReport()
        {
            return _newReportLibrary.PrintReport();
        }
    }
}
