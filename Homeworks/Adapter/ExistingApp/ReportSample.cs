using System.Text;

namespace Adapter.ExistingApp
{
    public class ReportSample
    {
        public void DoReport(IOldReportLibrary oldReportLibrary)
        {
            oldReportLibrary.AddHeader("Sample Header");
            oldReportLibrary.AddDetails(GetRandomDetails(10));
            oldReportLibrary.AddFooter("Sample footer");
            Console.WriteLine(oldReportLibrary.CreateReport());
        }

        private DateTime GetRandomDateTime()
        {
            var random = new Random();
            var currentYear = DateTime.Now.Year;
            var randomMonth = random.Next(1, 13);
            var daysInMonth = DateTime.DaysInMonth(currentYear, randomMonth);
            var randomDay = random.Next(1, daysInMonth + 1);
            return new DateTime(currentYear, randomMonth, randomDay);
        }

        public List<string> GetRandomDetails(int count)
        {
            var details = new List<string>();

            var stringBuilder = new StringBuilder();
            
            //Table Header
            stringBuilder.Append($"Código");
            stringBuilder.Append($"\t");

            stringBuilder.Append($"Usuario");
            stringBuilder.Append($"\t\t");

            stringBuilder.Append($"Fecha");
            details.Add(stringBuilder.ToString());
            stringBuilder.Clear();

            //Table Content
            for (int i = 0; i < count; i++)
            {
                var data = GetRandomDetail();
                stringBuilder.AppendLine($"\t");
                stringBuilder.Append($"{data["Código"]}");
                stringBuilder.Append($"\t");

                stringBuilder.Append($"{data["Usuario"]}");
                stringBuilder.Append($"\t");

                stringBuilder.Append($"{data["Fecha"]}");
            }

            details.Add(stringBuilder.ToString());
            stringBuilder.Clear();
            stringBuilder.AppendLine();
            details.Add(stringBuilder.ToString());
            return details;
        }

        private Dictionary<string, string> GetRandomDetail()
        {
            return new Dictionary<string, string>
            {
                { "Código", Guid.NewGuid().ToString("N")[..4] },
                { "Usuario", "ResarApp" },
                { "Fecha", GetRandomDateTime().ToString("yyyy-MM-dd") }
            };
        }
    }
}