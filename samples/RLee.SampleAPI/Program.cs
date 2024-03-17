using System.Text.Json;
using RLee.Core.Backend.Converters;
using RLee.Core.Frontend;
using RLee.Core.Frontend.Material;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var scaffold = new Scaffold()
        .SetAppBar(new AppBar())
        .SetBody(
            new Column()
            .SetChildren(new Row())
        )
        .SetBottomNavigationBar(new Row());

    var options = new JsonSerializerOptions
    {
        Converters = { new WidgetJsonConverter() },
        WriteIndented = true
    };

    var membersJson = JsonSerializer.Serialize<Widget>(scaffold, options);
    return Results.Ok(membersJson);
});

app.Run();

