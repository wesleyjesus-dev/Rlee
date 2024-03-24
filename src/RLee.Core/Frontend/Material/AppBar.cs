using RLee.Core.Frontend.Property;

namespace RLee.Core.Frontend.Material
{
    public class AppBar : Widget
    {
        public Color? Color { get; private set; }
        public Widget? Title { get; private set; }
        public Widget? Leading { get; private set; }

        public AppBar SetColor(Color color)
        {
            Color = color;
            return this;
        }

        public override string GetName() => "appBar";
    }
}

