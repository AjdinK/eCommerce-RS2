using eCommerce.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddTransient<IProductService, ProductService>();


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
        options.RoutePrefix = string.Empty;
        options.DocumentTitle = "eCommerceAPI";
        options.EnableDeepLinking();
    });
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();