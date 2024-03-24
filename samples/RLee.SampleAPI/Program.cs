using System.Text.Json;
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
            .SetChildren(new Row())
        )
        .SetBottomNavigationBar(new Row());

    return Results.Ok(scaffold);
});

app.Run();

