using Microsoft.AspNetCore.Mvc;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class ServicesController : ControllerBase
{
    public ServicesController(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DataContext DataContext { get; set; }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(DataContext.Services.ToList());
    }
    
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id )
    {
        return Ok(DataContext.Services.FirstOrDefault(a=>a.Id == id));
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id )
    {
        var entity = DataContext.Services.FirstOrDefault(a => a.Id == id);
        if (entity != null)
        {
            DataContext.Services.Remove(entity);
            DataContext.SaveChanges();
            return Ok();

        }
        return NotFound();
    }
    
    [HttpPost]
    public IActionResult Add(Service service )
    {
        DataContext.Services.Add(service);
        DataContext.SaveChanges();
        return Ok(service);
    }
}