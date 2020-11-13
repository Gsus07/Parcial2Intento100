using System;
using Entidad;

namespace segundoparcial.Models
{
    public class PagoInputModel{

        public int Id {get;set;} 
        public string TipoPago {get;set;}
        public DateTime Fecha {get;set;}
        public decimal ValorPago {get;set;}
        public decimal ValorIva {get;set;}
        
    }

    public class PagoViewModel : PagoInputModel
    {
        public PagoViewModel()
        {

        }
        public PagoViewModel(Pago pago)
        {
            Id = pago.Id;
            TipoPago = pago.TipoPago;
            Fecha = pago.Fecha;
            ValorPago = pago.ValorPago;
            ValorIva = pago.ValorIva;
            
        }
    }
}