using GS_EnergyWise.Application.DOTs;
using GS_EnergyWise.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GS_EnergyWise.Presentation.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ComunidadeController : ControllerBase
{
    private readonly IComunidadeApplicationService _comunidadeApplicationService;

    public ComunidadeController(IComunidadeApplicationService comunidadeApplicationService)
    {
        _comunidadeApplicationService = comunidadeApplicationService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        try
        {
            var comunidades = _comunidadeApplicationService.GetAll();
            
            if (comunidades == null)
            {
                return NotFound();
            }
            
            return Ok(comunidades);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        try
        {
            var comunidade = _comunidadeApplicationService.GetById(id);
            
            if (comunidade == null)
            {
                return NotFound();
            }
            
            return Ok(comunidade);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost]
    public IActionResult Add([FromBody] ComunidadeDTO comunidadeDTO)
    {
        try
        {
            _comunidadeApplicationService.Add(comunidadeDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] ComunidadeDTO comunidadeDTO)
    {
        try
        {
            _comunidadeApplicationService.Update(id, comunidadeDTO);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            _comunidadeApplicationService.Delete(id);
            return Ok();
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}