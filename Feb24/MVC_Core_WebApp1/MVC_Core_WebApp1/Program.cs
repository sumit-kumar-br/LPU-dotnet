var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Middleware 1 called.");
//    await next.Invoke();
//});

//app.Use(async (context, next) =>
//{
//    await next.Invoke();
//    await context.Response.WriteAsync("Middleware 2 called.");
//});

//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Middleware 3 called.");
//});

//app.MapStaticAssets();

app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Student}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();



