using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using RLee.Core.Frontend;

namespace RLee.SampleAPI
{
    public class WidgetService
    {
        public Widget CreateWidget()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "widget.json");
            
            var document = JsonDocument.Parse(json);

            foreach (var property in document.RootElement.EnumerateObject())
            {

            }

            return new Column();
        }

        public bool ContainsChildren(string? type)
        {
            if(!string.IsNullOrEmpty(type) || type == "column" || type == "row")
            {
                return true;
            }

            return false;
        }
    }
}