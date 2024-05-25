using Adapter.Adpater;
using Adapter.ExistingApp;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**** Old Report Library ***");
            Console.ResetColor();

            var freeReportLibrary = new FreeReportLibrary();
            var reportSample = new ReportSample();
            reportSample.DoReport(freeReportLibrary);
 
            #region Adapter Calling
            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("**** New Report Library (Adapter) ***");
            //Console.ResetColor();
            //var newReportLibrary = new NewReportLibrary();
            //var adapter = new FreeReportLibraryReportToNewReportLibraryAdapter(newReportLibrary);
            //reportSample.DoReport(adapter); 
            #endregion

            var newReportLibrary = new NewReportLibrary();
            var adapter = new FreeReportLibraryReportToNewReportLibraryAdapter(newReportLibrary);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Let's create a new Report using the new Library (Adapter): ");
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
            Console.WriteLine(adapter.CreateReport());
            Console.ResetColor();
        }
    }
}
