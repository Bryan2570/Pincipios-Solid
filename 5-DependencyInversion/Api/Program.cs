using DependencyInversion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IStudentRepository,StudentRepository>();
builder.Services.AddScoped<ILogbook,Logbook>();

//AddScoped -->>  Se crea por cada componente que lo esta utilizando
//AddSingleton -->> quiere decir que la referencia va a ser la misma durante todo el ciclo de vida de la api
//AddTransient  -->> Se crea una referencia de essa dependencia en todas las partes donde se utilice incluso dentro del mismo componente

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
