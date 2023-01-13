using FirstSteps.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var userList = new List<User>()
    {
        new User(1, "Arif", "Acar"),
        new User(2, "Birol", "Bilgili")
    };
    
    return userList;
});

app.Run();