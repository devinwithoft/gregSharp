using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HomesController : ControllerBase
{
  private readonly HomesService _homesService;

  public HomesController(HomesService homesService)
  {
    _homesService = homesService;
  }

  [HttpGet]
  public ActionResult<List<Home>> Get()
  {
    try
    {
      List<Home> homes = _homesService.Get();
      return Ok(homes);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }



  [HttpGet("{id}")]
  public ActionResult<Home> Get(int id)
  {
    try
    {
      Home home = _homesService.Get(id);
      return Ok(home);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{id}")]
  public ActionResult<String> Remove(int id)
  {
    try
    {
      String message = _homesService.Remove(id);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{id}")]
  public ActionResult<Home> Update([FromBody] Home homeUpdate, int id)
  {
    try
    {
      Home home = _homesService.Update(homeUpdate, id);
      return Ok(home);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }


  [HttpPost]
  public ActionResult<Home> Create([FromBody] Home homeData)
  {
    try
    {
      Home home = _homesService.Create(homeData);
      return Ok(home);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

}

