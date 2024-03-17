namespace RLee.Core.Frontend.Material {

    /// <summary>
    /// https://api.flutter.dev/flutter/material/Scaffold-class.html
    /// </summary>
    public class Scaffold : Widget
    {
        public Scaffold(Widget appBar, Widget body, Widget bottomNavigationBar)
        {
            AppBar = appBar;
            Body = body;
            BottomNavigationBar = bottomNavigationBar;
        }

        public Scaffold() { }
        public Scaffold(Widget body) => Body = body;
        
        public Widget? AppBar { get; set; }
        public Widget? Body { get; set; }
        public Widget? BottomNavigationBar { get; private set; }

        public override string GetName() => "Scaffold";

        public Scaffold SetAppBar(Widget widget)
        {
            AppBar = widget;
            return this;
        }

        public Scaffold SetBody(Widget widget)
        {
            Body = widget;
            return this;
        }

        public Scaffold SetBottomNavigationBar(Widget widget)
        {
            BottomNavigationBar = widget;
            return this;
        }
    }
}

