using System; 

namespace ReporteAccidente.App.Dominio
{
    public class Accidente
    {
        public int Id{get;set;}
        public int IdAgente{get;set;}
        public string Latitud{get;set;}
        public string Longitud{get;set;}
        public string Direccion{get;set;}
        public string Fecha{get;set;}
        public string Hora{get;set;}


    }
}