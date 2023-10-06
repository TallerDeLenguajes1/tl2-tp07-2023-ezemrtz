using Microsoft.AspNetCore.Mvc;
using webApi;

namespace tl2_tp07_2023_ezemrtz.Controllers;

[ApiController]
[Route("[controller]")]
public class ManejoTareasController : ControllerBase
{
    ManejoTareas manejoTareas;
    private readonly ILogger<ManejoTareasController> _logger;

    public ManejoTareasController(ILogger<ManejoTareasController> logger)
    {
        _logger = logger;
        manejoTareas = new ManejoTareas();
    }

    [HttpGet("GetTarea")]
    public ActionResult<Tarea> GetTarea(int id)
    {
       var tarea = manejoTareas.GetTarea(id);
        return Ok(tarea);
    }
    [HttpGet("GetTareas")]
    public ActionResult<Tarea> GetTareas()
    {
       var tarea = manejoTareas.GetTareas();
        return Ok(tarea);
    }
    [HttpGet("GetTareasCompletadas")]
    public ActionResult<Tarea> GetTareasCompletadas()
    {
       var tarea = manejoTareas.GetTareasCompletadas();
        return Ok(tarea);
    }
    [HttpPost("CrearTarea")]
    public ActionResult<Tarea> CrearTarea(Tarea tarea)
    {
       var nuevaTarea = manejoTareas.CrearTarea(tarea);
        return Ok(tarea);
    }
    [HttpPut("ActualizarTarea")]
    public ActionResult<Tarea> ActualizarTarea(int id, Estados estado)
    {
       var nuevaTarea = manejoTareas.ActualizarTarea(id, estado);
        return Ok(nuevaTarea);
    }
    [HttpDelete("EliminarTarea")]
    public ActionResult<Tarea> EliminarTarea(int id)
    {
       var tarea = manejoTareas.EliminarTarea(id);
        return Ok(tarea);
    }

}
