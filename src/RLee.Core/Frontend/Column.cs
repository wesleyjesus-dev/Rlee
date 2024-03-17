using RLee.Core.Frontend.Property;

namespace RLee.Core.Frontend
{
    /// <summary>
    /// A widget that displays its children in a vertical array.
    /// Most references in https://api.flutter.dev/flutter/widgets/Column-class.html
    /// </summary>
    public class Column : Widget
    {
        public CrossAxisAlignment CrossAxisAlignment = CrossAxisAlignment.Center;

        public MainAxisAlignment MainAxisAlignment = MainAxisAlignment.Start;

        public MainAxisSize MainAxisSize = MainAxisSize.Max;

        public List<Widget> Children { get; set; } = new();

        public Column SetChildren(Widget widget)
        {
            Children.Add(widget);
            return this;
        }

        public override string GetName() => "Column";
    }
}

