using RLee.Core.Frontend;
using Xunit;

namespace RLee.UnitTests.Frontend
{
    public class ColumnTests
    {
        [Fact(DisplayName = "Must contain two children")]
        public void MustContainTwoChildren()
        {
            var column = new Column()
                .SetChildren(new Row())
                .SetChildren(new Row());

            Assert.True(column.Children.Count == 2);
        }   
    }
}

