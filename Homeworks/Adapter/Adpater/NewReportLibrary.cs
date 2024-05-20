using System.Text;

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
            return $"GroupHeader-{this._groupHeaderId++}";
        }

        public string CreateGroupFooter()
        {
            return $"GroupFooter-{this._groupFooterId++}";
        }

        public string CreateGroupDetail()
        {
            return $"GroupDetail-{this._groupDetailId++}";
        }

        public void AddText(string objectId, string value)
        {
            this._content.Add(objectId, value);
        }

        public void AddText(string objectId, Dictionary<string, string> value)
        {
            this._content.Concat(value);
        }

        public string PrintReport()
        {
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

            return stringBuilder.ToString();
        }

        private string AddLine()
        {
            return "+--------------------------------------------+";
        }
    }
}
