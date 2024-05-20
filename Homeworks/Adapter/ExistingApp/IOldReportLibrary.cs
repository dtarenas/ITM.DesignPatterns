namespace Adapter.ExistingApp
{
    public interface IOldReportLibrary
    {
        void AddHeader(string header);
        void AddDetails(List<string> detail);
        void AddFooter(string footer);
        string CreateReport();
    }
}