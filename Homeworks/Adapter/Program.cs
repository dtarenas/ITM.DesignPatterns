using Adapter.Adpater;
using Adapter.ExistingApp;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            var newReportLibrary = new NewReportLibrary();
            var adapter = new FreeReportLibraryReportToNewReportLibraryAdapter(newReportLibrary);
            var reportSample = new ReportSample();
            reportSample.DoReport(adapter);


            newReportLibrary = new NewReportLibrary();
            adapter = new FreeReportLibraryReportToNewReportLibraryAdapter(newReportLibrary);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's create a new Report using the new Library: ");
            Console.WriteLine("Add the header: ");
            var header = Console.ReadLine();

            var details = new List<string>();
            Console.WriteLine("Add the details: ");
            while (true)
            {
                var detail = Console.ReadLine();
                if (detail.Contains("done", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                } 

                details.Add(detail);
            }

            Console.WriteLine("Add the footer: ");
            var footer = Console.ReadLine();

            adapter.AddHeader(header);  
            adapter.AddFooter(footer);
            adapter.AddDetails(details);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(adapter.CreateReport());
            Console.ResetColor();
        }
    }
}
