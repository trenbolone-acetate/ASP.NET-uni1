using ASPNET1;

var builder = WebApplication.CreateBuilder(args);



var app = builder.Build();

// Company myCompany = new Company(
//     name: "Megasoft",
//     address: "123 Innovation Avenue, Tech City, TX",
//     numberOfEmployees: 50,
//     foundedDate: new DateTime(2024, 9, 4)
// );
Random _random = new Random();
app.Run(async (context) =>

{
    //await context.Response.WriteAsync(myCompany.GetCompanyInfo());
    context.Response.Headers.Append("Name", "Random Number");
    await context.Response.WriteAsync($"<h2>Number: {_random.Next(0,101).ToString()}</h2>");
});

app.Run();