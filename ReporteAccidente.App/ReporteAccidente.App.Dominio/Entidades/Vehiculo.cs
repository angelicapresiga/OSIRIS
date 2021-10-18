using System;
using System.ComponentModel.DataAnnotations;
namespace ReporteAccidente.App.Dominio
{
    public class Vehiculo
    {
        public int Id{get;set;}
        [Required,StringLength(6)]
        public string Placa{get;set;}
         [Required,StringLength(15)]
        public string Marca{get;set;}
        [Required,Range(1900, 2021)]
        public int Modelo{get;set;}
    }
}