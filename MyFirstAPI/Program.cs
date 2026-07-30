using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();




app.MapControllers();
app.Run();


public class Employee
{
    public string Name { set; get; }
    public int ID { set; get; }

    public Employee()
    {
        
    }

    public Employee(string name,int id)
    {
        ID = id;
        Name = name;
    }
}