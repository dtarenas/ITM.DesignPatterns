namespace Adapter.ExistingApp
{
    public interface IFreeReportLibrary
    {
        void AddHeader(string header);
        void AddDetails(List<string> detail);
        void AddFooter(string footer);
        string CreateReport();
    }
}