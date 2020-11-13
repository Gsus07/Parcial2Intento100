using System.Collections.Generic;
using System.Linq;
using Datos;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using segundoparcial.Models;

namespace segundoparcial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagoController : ControllerBase
    {
         private readonly PagoService pagoService;
        public PagoController(TerceroContext context){
    
            pagoService = new PagoService(context);
        }

        // GET: api/Pago
        [HttpGet()]
        public IEnumerable<PagoViewModel> Gets(){
            var pagos = pagoService.ConsultarTodos().Select(p=> new PagoViewModel(p));
            return pagos;
        }

        // POST: api/Pago
        [HttpPost]
        public ActionResult<PagoViewModel> Post(PagoInputModel pagoInput){            
            Pago pago = MapearPago(pagoInput);
            var response = pagoService.Guardar(pago);

            if (response.Error)
            {
            return BadRequest(response.Mensaje);
            }
            return Ok(response.Pago);
        }

        private Pago MapearPago(PagoInputModel pagoInput){
            var pago = new Pago();            
            
                pago.TipoPago=pagoInput.TipoPago;
                pago.Fecha=pagoInput.Fecha;
                pago.ValorPago=pagoInput.ValorPago;
                pago.ValorIva=pagoInput.ValorIva;
                
            return pago;
        }

    }
}