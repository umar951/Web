using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Web.Domain.Entities;
using Web.Infrastructure.Ef;

namespace Web.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class AdvantagesController : ControllerBase
{
    public AdvantagesController(DataContext dataContext)
    {
        DataContext = dataContext;
    }

    public DataContext DataContext { get; set; }

    [HttpGet]
    public IActionResult GetList()
    {
        return Ok(DataContext.Advantages.ToList());
    }
    
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id )
    {
        return Ok(DataContext.Advantages.FirstOrDefault(a=>a.Id == id));
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(int id )
    {
        var entity = DataContext.Advantages.FirstOrDefault(a => a.Id == id);
        if (entity != null)
        {
            DataContext.Advantages.Remove(entity);
            DataContext.SaveChanges();
            return Ok();

        }
        return NotFound();
    }
    
    [HttpPost]
    public IActionResult Add(Advantage advantage )
    {
        DataContext.Advantages.Add(advantage);
        DataContext.SaveChanges();
        return Ok(advantage);
    }
}