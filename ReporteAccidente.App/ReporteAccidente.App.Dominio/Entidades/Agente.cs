using System;
using System.ComponentModel.DataAnnotations;

namespace ReporteAccidente.App.Dominio
{
    public class Agente
    {
         [Required]
        public int Id{get;set;}
         [Required]
        public string Nombre{get;set;}
        
    }
}