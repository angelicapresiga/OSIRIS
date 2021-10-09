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
        private readonly IRepositorioVehiculo repositorioVehiculo;
        private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        public IEnumerable<Vehiculo> Vehiculos{get;set;}

        public ReporteVehiculoModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo=repositorioVehiculo;
        }
        public void OnGet()
        {
            Vehiculos=_repoVehiculo.GetAllVehiculos();
        }
    }
}
