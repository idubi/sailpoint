var builder = WebApplication.CreateBuilder(args);
//Access to XMLHttpRequest at
//'https://localhost:7152/api/AutoComplete/get_match?fileName=world-cities&query=fa'
//from origin 'http://localhost:4200' has been blocked by CORS policy: Request header field access-control-allow-credentials
//is not allowed by Access-Control-Allow-Headers in preflight response.
//autoComplete.service.ts:9 ERROR Error: Uncaught (in promise): AxiosError: Network Error
//Add services to the container.




builder.Services.AddControllers();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy => policy.WithOrigins("http://localhost:4200").AllowCredentials());
});

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
app.UseStaticFiles();

app.UseRouting();
app.UseCors("AllowOrigin");
app.UseCors("AllowCredentials");

app.UseCors(builder =>
{
    builder.AllowAnyHeader();
    builder.AllowAnyMethod();
    builder.WithOrigins("AllowAll");
});


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
