using RLee.Core.Frontend;

namespace RLee.UnitTests;

public class UnitTest1
{
    [Fact]
    public void WhenAddRowInColumnTheColumnShouldBeAItem()
    {
        var column = new Column();
        column.SetChildren(new Row());
        Assert.Contains(new Row(), column.Children);
    }
}