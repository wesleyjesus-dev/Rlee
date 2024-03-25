using System.Text.Json;
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
        
        string json = @"{\r\n  \'appBar\': {\r\n    \'color\': null,\r\n    \'title\': null,\r\n    \'leading\': null,\r\n    \'$type\': \'appBar\',\r\n    \'key\': \'8420ac97-9796-4f81-a27a-2ff48e857ccf\'\r\n  },\r\n  \'body\': {\r\n    \'children\': [\r\n      {\r\n        \'$type\': \'row\',\r\n        \'key\': \'42ca0214-3441-4982-b132-0beec623c75b\'\r\n      },\r\n      {\r\n        \'$type\': \'row\',\r\n        \'key\': \'6f4446e4-a448-4e3a-a138-fb07bb7f0c8f\'\r\n      }\r\n    ],\r\n    \'clipBehavior\': \'None\',\r\n    \'crossAxisAlignment\': \'Center\',\r\n    \'direction\': \'Vertical\',\r\n    \'mainAxisAlignment\': \'Start\',\r\n    \'mainAxisSize\': \'Max\',\r\n    \'textBaseline\': \'Alphabetic\',\r\n    \'$type\': \'column\',\r\n    \'key\': \'9f794a2f-c8bf-4c8b-8e98-2d6eaf320ea3\'\r\n  },\r\n  \'bottomNavigationBar\': {\r\n    \'$type\': \'row\',\r\n    \'key\': \'26f1c90d-919a-4c92-8835-c3a353a996dd\'\r\n  },\r\n  \'$type\': \'row\',\r\n  \'key\': \'980f517b-9b23-4124-9d24-d8599e948fda\'\r\n}'";

        [Fact]
        public void Teste()
        {
            var parsed = JsonDocument.Parse(json);
            var type = parsed.RootElement.GetProperty("$type");
            Console.WriteLine(type);
        }
    }
}

