using System.Text;

namespace Adapter.ExistingApp
{
    public class FreeReportLibrary : IFreeReportLibrary
    {
        private readonly StringBuilder _reportContent;

        public FreeReportLibrary()
        {
            this._reportContent = new StringBuilder();
        }

        public void AddDetails(List<string> detail)
        {
            Console.WriteLine("Calling AddDetails()");
            detail.ForEach(x => _reportContent.AppendLine(x));
        }

        public void AddFooter(string footer)
        {
            Console.WriteLine("Calling AddFooter()");
            _reportContent.AppendLine("+--------------------------------------------+");
            _reportContent.AppendLine($"\t\t{footer}");
            _reportContent.AppendLine("+--------------------------------------------+");
        }

        public void AddHeader(string header)
        {
            Console.WriteLine("Calling AddHeader()");
            _reportContent.AppendLine("+--------------------------------------------+");
            _reportContent.AppendLine($"\t\t{header}");
            _reportContent.AppendLine("+--------------------------------------------+");
        }

        public string CreateReport()
        {
            Console.WriteLine("Calling CreateReport()");
            return _reportContent.ToString();
        }
    }
}
