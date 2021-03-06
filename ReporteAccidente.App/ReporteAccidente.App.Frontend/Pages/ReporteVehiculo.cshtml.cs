using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReporteAccidente.App.Persistencia;
using ReporteAccidente.App.Dominio;

namespace ReporteAccidente.App.Frontend.pages
{
    public class ReporteVehiculoModel : PageModel
    {
        
        private readonly IRepositorioVehiculo repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
       
        public IEnumerable<Vehiculo> vehiculos{get;set;}


        public void OnGet() => vehiculos = repoVehiculo.GetAllVehiculos();
    }
}
