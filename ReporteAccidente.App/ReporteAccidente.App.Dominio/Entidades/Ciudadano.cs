using System;
using System.ComponentModel.DataAnnotations;
namespace ReporteAccidente.App.Dominio
{
    public class Ciudadano
    {
        public int Id{get;set;}
        [Required,StringLength(50)]
        public string Nombre{get;set;}
         [Required]
        public string Sexo{get;set;}
         [Required]
        public int Edad{get;set;}
         [Required]
        public string TipoAgenteVial{get;set;}
        

    }
}