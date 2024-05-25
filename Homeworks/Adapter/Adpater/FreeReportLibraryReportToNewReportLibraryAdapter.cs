using Adapter.ExistingApp;

namespace Adapter.Adpater
{
    public class FreeReportLibraryReportToNewReportLibraryAdapter : IFreeReportLibrary
    {
        private readonly NewReportLibrary _newReportLibrary;

        public FreeReportLibraryReportToNewReportLibraryAdapter(NewReportLibrary newReport)
        {
            this._newReportLibrary = newReport;
        }

        public void AddDetails(List<string> details)
        {
            PrintTrace("AddDetails()");
            var groupDetail = _newReportLibrary.CreateGroupDetail();
            var textValue = string.Join("\n", details);
            _newReportLibrary.AddText(groupDetail, textValue);
        }

        public void AddFooter(string footer)
        {
            PrintTrace("AddFooter()");
            var groupFooter = _newReportLibrary.CreateGroupFooter();
            _newReportLibrary.AddText(groupFooter, footer);
        }

        public void AddHeader(string header)
        {
            PrintTrace("AddHeader()");
            var groupHeader = _newReportLibrary.CreateGroupHeader();
            _newReportLibrary.AddText(groupHeader, header);
        }

        public string CreateReport()
        {
            PrintTrace("CreateReport()");
            return _newReportLibrary.PrintReport();
        }

        private static void PrintTrace(string trace)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Calling {trace}");
            Console.ResetColor();
        }
    }
}
