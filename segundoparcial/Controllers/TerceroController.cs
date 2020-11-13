using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using presentacion.Models;
using System.Collections.Generic;
using System.Linq;
namespace ParcialDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TerceroController : ControllerBase
    {
        private readonly TerceroService terceroService;
        public TerceroController(TerceroContext context)
        {
            terceroService = new TerceroService(context);
        }

        // GET: api/Tercero
        [HttpGet()]
        public IEnumerable<TerceroViewModel> Gets()
        {
            var terceros = terceroService.ConsultarTodos().Select(p => new TerceroViewModel(p));
            return terceros;
        }

        // POST: api/Tercero
        [HttpPost]
        public ActionResult<TerceroViewModel> Post(TerceroInputModel terceroInput)
        {
            Tercero tercero = Mapear(terceroInput);
            var response = terceroService.Guardar(tercero);

            if (response.Error)
            {
                return BadRequest(response.Mensaje);
            }
            return Ok(response.Tercero);
        }
        private Tercero Mapear(TerceroInputModel terceroInput)
        {
            Tercero tercero = new Tercero
            {
                Identificacion = terceroInput.Identificacion,
                TipoIdentificacion = terceroInput.TipoIdentificacion,
                Nombre = terceroInput.Nombre,
                TipoTercero = terceroInput.TipoTercero,
                Direccion = terceroInput.Direccion,
                Telefono = terceroInput.Telefono,
                Pais = terceroInput.Pais,
                Departamento = terceroInput.Departamento,
                Ciudad = terceroInput.Ciudad


            };

            return tercero;
        }

        
    }
}