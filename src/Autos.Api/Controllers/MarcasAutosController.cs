using Autos.Repository.Models;
using Autos.Services.MarcasAutos;
using Autos.Services.MarcasAutos.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Autos.Api.Controllers;

[Route("[controller]")]
[ApiController]
public class MarcasAutosController : ControllerBase
{
    private readonly IMarcasAutoService _marcasAutoService;

    public MarcasAutosController(IMarcasAutoService marcasAutoService)
    {
        _marcasAutoService = marcasAutoService;
    }

    /// <summary>Returns all marcas & autos.</summary>
    /// <returns>Returns all marcas & autos.</returns>
    /// <response code ="200">Returns data.</response>
    /// <response code ="500">Returns an Internal Server Error.</response>
    /// <remarks>MarcasAutos</remarks>
    [Produces("application/json")]
    [ProducesResponseType(typeof(IEnumerable<MarcasAuto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    [HttpGet]
    public async Task<IActionResult> GetAsync()
    {
        var result = await _marcasAutoService.GetAsync();
        return Ok(result);
    }
}
