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
        [BindProperty]
        public Ciudadano ciudadano { get; set; }
              

        public EditCiudadanoModel(IRepositorioCiudadano repositorioCiudadano) => this.repositorioCiudadano = repositorioCiudadano;

        public IActionResult OnGet(int? ciudadanoId)
        {
             if(ciudadanoId.HasValue)
            {
                ciudadano = repositorioCiudadano.GetCiudadano(ciudadanoId.Value);
            }
            else
            {
                ciudadano= new Ciudadano();
            }
            if (ciudadano == null)
            {
                return RedirectToPage("./NotFound");
            }
            else

                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
             if(ciudadano.Id>0)
            {
             ciudadano = repositorioCiudadano.UpdateCiudadano(ciudadano);
            }
            else
            {
                repositorioCiudadano.AddCiudadano(ciudadano);
            }
            return Page();
        }
    }
}
