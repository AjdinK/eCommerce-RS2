using eCommerce.Services;
using eCommerce.Services.Database;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IProductTypeService, ProductTypeService>();

// Configure database
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ??
                       "Server=localhost,1433;Database=semDB;Trusted_Connection=false;User ID=sa;Password=yourStrong123Aaa_aPassword; MultipleActiveResultSets=true;TrustServerCertificate=true";
builder.Services.AddDatabaseServices(connectionString);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Ensure database is created
using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<eCommerceDbContext>();
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        options.RoutePrefix = string.Empty;
        options.DocumentTitle = "eCommerceAPI-test";
        options.EnableDeepLinking();
    });
}


app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();