using System.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entidad
{
    public class Tercero
    {
        [Key]
        [MaxLength(10)]
        public string Identificacion { get; set; }
        [MaxLength(5)]
        public string TipoIdentificacion { get; set; }
        [MaxLength(20)]
        public string Nombre { get; set; }
        [MaxLength(15)]
        public string TipoTercero { get; set; }
        [MaxLength(15)]
        public string Direccion { get; set; }
        [MaxLength(2)]
        public string Telefono { get; set; }
        [MaxLength(15)]
        public string Pais { get; set; }
        [MaxLength(15)]   
        public string Departamento { get; set; }
        [MaxLength(15)]
        public string Ciudad { get; set;}
        //public List<Pago> Pagos { get; set; }
    }
}
