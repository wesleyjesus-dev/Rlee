namespace RLee.Core.Frontend
{
    public abstract class Widget
    {
        public string Name => GetName();

        public Widget()
        {
            
            Key = Guid.NewGuid().ToString();
        }

        public Widget(string key) => Key = key;

        public string Key { get; set; }

        public abstract string GetName();
    }
}

