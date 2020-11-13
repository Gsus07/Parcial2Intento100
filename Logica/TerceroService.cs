using System;
using System.Collections.Generic;
using Datos;
using Entidad;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class TerceroService
    {
        private readonly TerceroContext context;
        public TerceroService(TerceroContext tercerocontext){
            context = tercerocontext;
        }

        public GuardarTerceroResponse Guardar(Tercero tercero)
        {
            try
            {
                var TerceroBuscado = context.Terceros.Find(tercero.Identificacion);
                if(TerceroBuscado != null){
                    return new GuardarTerceroResponse("Ya se encuentra en el sistema");
                }
                context.Terceros.Add(tercero);
                context.SaveChanges();
                return new GuardarTerceroResponse(tercero);
            }
            catch (Exception e)
            {
                return new GuardarTerceroResponse($"Error de la Aplicacion: {e.Message}");
            }
            finally { }
        }
        public List<Tercero> ConsultarTodos()
        {
            List<Tercero> terceros = context.Terceros.ToList();

            return terceros;
        }
        
    }
    public class GuardarTerceroResponse 
    {
        public GuardarTerceroResponse(Tercero tercero)
        {
            Error = false;
            Tercero = tercero;
        }
        public GuardarTerceroResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Tercero Tercero { get; set; }
    }
}
