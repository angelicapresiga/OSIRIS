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
    public class EditCiudadanoModel : PageModel
    {
        private readonly IRepositorioCiudadano repositorioCiudadano;
         private static IRepositorioCiudadano _repoCiudadano = new RepositorioCiudadano(new Persistencia.AppContext());

       [BindProperty]
        public Ciudadano ciudadano { get; set; }
             
        public EditCiudadanoModel(IRepositorioCiudadano repositorioCiudadano)
        {
            this.repositorioCiudadano = repositorioCiudadano;
        }

        public IActionResult OnGet(int ciudadanoId)
        {
            ciudadano = _repoCiudadano.GetCiudadano(ciudadanoId);
            if (ciudadanoId == null)
            {
                return RedirectToPage("./NotFound");
            }
            else

                return Page();

        }

        public IActionResult OnPost()
        {
            ciudadano = _repoCiudadano.UpdateCiudadano(ciudadano);
            return Page();
        }
    }
}
