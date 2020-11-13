using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Pago
    {
        [Key]
        [MaxLength(10)]
        public int Id {get;set;}
        [MaxLength(10)]
        public string TipoPago {get;set;}
        [DataType(DataType.Date)]
        public DateTime Fecha {get;set;}
        public decimal ValorPago{get;set;}
        public decimal ValorIva {get;set;}
    }
}