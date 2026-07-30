using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeesController : ControllerBase
{
    private static List<Employee> list = new List<Employee>()
    {
        new Employee("Ahmed", 102030),
        new Employee("Qusai", 102031),
        new Employee("Hiba", 102032)
    };

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(list);
    }


    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ID == id)
            {
                return Ok(list[i]); 
            }
        }

        return NotFound($"Employee with ID {id} not found."); 
    }

    [HttpPost()]
    public IActionResult PostE(int id,string name)
    {
        list.Add(new Employee(name,id));
        return Ok(list);
    }

    [HttpDelete()]
    public IActionResult DelE(int id)
    {
        List<Employee> NewList = new List<Employee>();
        for(int i=0;i<list.Count;i++)
            if(id!=list[i].ID) NewList.Add(list[i]);

        list = NewList;
        return Ok(list);
    }

    [HttpPut()]

    public IActionResult PutE(int id,string name)
    {
        for(int i=0;i<list.Count; i++)
            if(id==list[i].ID) list[i].Name = name;

        return Ok(list);
    }
}






