using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ReporteAccidente.App.Persistencia;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Frontend.Pages
{
    public class EditVehiculoModel : PageModel
    {
       private readonly IRepositorioVehiculo repositorioVehiculo;
       private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

       [BindProperty]
        public Vehiculo vehiculo { get; set; }
             
        public EditVehiculoModel(IRepositorioVehiculo repositorioVehiculo)
        {
            this.repositorioVehiculo = repositorioVehiculo;
        }

        public IActionResult OnGet(int vehiculoId)
        {
            vehiculo = _repoVehiculo.GetVehiculo(vehiculoId);
            if (vehiculoId == null)
            {
                return RedirectToPage("./NotFound");
            }
            else

                return Page();

        }

        public IActionResult OnPost()
        {
            vehiculo = _repoVehiculo.UpdateVehiculo(vehiculo);
            return Page();
        }
    }
}
