using Swashbuckle.AspNetCore.SwaggerGen;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();


List<Employee> list = new List<Employee>()
{
    new Employee("Ahmed",102030),
    new Employee("Qusai",102031),
    new Employee("Hiba",102032)
};

app.MapGet("/app",()=>
{
    return list;
}
);

app.MapGet("/app/{id}", (int id) =>
{
    for(int i = 0;i<list.Count; i++)
        if(list[i].ID == id)
        {
            return Results.Ok(list[i]);
        }
    return Results.NotFound("NOT FOUND");
}
);

app.MapPost("/app",(string name,int id)=>
{list.Add(new Employee(name,id));

    return list;
}
    
    );

app.MapDelete("/app", (int id) =>
{
    List<Employee> Newlist = new List<Employee>();
    for(int i=0;i<list.Count;i++)
        if(list[i].ID != id) Newlist.Add(list[i]);
    list = Newlist;
});

app.MapPut("/app",(int id,string name) => {

    for(int i=0;i<list.Count;i++)
        if(list[i].ID == id) list[i].Name = name;

});


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