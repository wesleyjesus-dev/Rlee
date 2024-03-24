using RLee.Core.Frontend.Property;

namespace RLee.Core.Frontend
{
    /// <summary>
    /// A widget that displays its children in a vertical array.
    /// Most references in https://api.flutter.dev/flutter/widgets/Column-class.html
    /// </summary>
    public class Column : Widget
    {
        public List<Widget> Children { get; set; } = new();
        public Clip ClipBehavior { get; set;}
        public CrossAxisAlignment CrossAxisAlignment { get; set;} = CrossAxisAlignment.Center;
        public Axis Direction{ get; set;} = Axis.Vertical;
        public MainAxisAlignment MainAxisAlignment { get; set;} = MainAxisAlignment.Start;
        public MainAxisSize MainAxisSize { get; set;} = MainAxisSize.Max;
        public TextBaseline TextBaseline { get; set;} = TextBaseline.Alphabetic;


        public Column SetChildren(Widget widget)
        {
            Children.Add(widget);
            return this;
        }

        public override string GetName() => "column";
    }
}

