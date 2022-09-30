

var builder = WebApplication.CreateBuilder(args);


//connect databases

//builder.Services.AddDbContext<MvcUserContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcUserContext")));

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

//app.MapGet("/about", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
    );

app.UseAuthorization();

app.MapRazorPages();

app.Run();
