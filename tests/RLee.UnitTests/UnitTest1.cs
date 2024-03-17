namespace RLee.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {

    }

    [Fact]
    public void WhenCreateAColumnShoudHaveARow()
    {
        var column = new Column();
        column.AddChildren(new Row());
        Assert.Contains(new Row(), column.Childrens);
    }
}

public class Widget
{
    public Widget()
    {
        Key = Guid.NewGuid().ToString();
    }

    public Widget(string key) => Key = key;

    public string Key { get; set; }
}

public class Column : Widget
{
    public List<Widget> Childrens { get; private set; } = new();

    public Column AddChildren(Widget widget)
    {
        Childrens.Add(widget);
        return this;
    }
}

public class Row : Widget
{
    public List<Widget> Children { get; set; } = new();
}