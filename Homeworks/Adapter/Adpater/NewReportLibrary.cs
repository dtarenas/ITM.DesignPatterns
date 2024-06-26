﻿using System.Text;

namespace Adapter.Adpater
{
    public class NewReportLibrary
    {
        private int _groupHeaderId = 0;
        private int _groupFooterId = 0;
        private int _groupDetailId = 0;
        private readonly Dictionary<string, string> _content = [];

        public string CreateGroupHeader()
        {
            Console.WriteLine("\tCalling CreateGroupHeader()");
            return $"GroupHeader-{this._groupHeaderId++}";
        }

        public string CreateGroupFooter()
        {
            Console.WriteLine("\tCalling CreateGroupFooter()");
            return $"GroupFooter-{this._groupFooterId++}";
        }

        public string CreateGroupDetail()
        {
            Console.WriteLine("\tCalling CreateGroupDetail()");
            return $"GroupDetail-{this._groupDetailId++}";
        }

        public void AddText(string objectId, string textValue)
        {
            Console.WriteLine("\tCalling AddText()");
            this._content.Add(objectId, textValue);
        }

        public string PrintReport()
        {
            Console.WriteLine("\tInit PrintReport()");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(AddLine());
            for (int i = 0; i < this._groupHeaderId; i++)
            {
                this._content.TryGetValue($"GroupHeader-{i}", out string value);
                stringBuilder.AppendLine($"\t\t{value}");
            }

            stringBuilder.AppendLine(AddLine());
            for (int i = 0; i < this._groupDetailId; i++)
            {
                this._content.TryGetValue($"GroupDetail-{i}", out string value);
                stringBuilder.AppendLine(value);
            }

            stringBuilder.AppendLine(AddLine());
            for (int i = 0; i < this._groupFooterId; i++)
            {
                this._content.TryGetValue($"GroupFooter-{i}", out string value);
                stringBuilder.AppendLine($"\t\t{value}");
            }

            stringBuilder.AppendLine(AddLine());
            Console.WriteLine("\tEnd PrintReport()");
            return stringBuilder.ToString();
        }

        private string AddLine()
        {
            Console.WriteLine("\tCalling AddLine()");
            return "+--------------------------------------------+";
        }
    }
}
