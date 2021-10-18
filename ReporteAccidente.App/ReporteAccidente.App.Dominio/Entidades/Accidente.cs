using System; 
using System.ComponentModel.DataAnnotations;
namespace ReporteAccidente.App.Dominio
{
    public class Accidente
    {
        public int Id{get;set;}

        [Required]
        public int IdAgente{get;set;}

        [Required]
        public string Latitud{get;set;}

        [Required]
        public string Longitud{get;set;}
        [Required,StringLength(50)]
        public string Direccion{get;set;}

        [Required,StringLength(15)]
        public string Fecha{get;set;}

        [Required,StringLength(5)]
        public string Hora{get;set;}


    }
}