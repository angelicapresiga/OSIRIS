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
    public class EdtiAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;
       [BindProperty]
        public Accidente accidente { get; set; }
             
        public EdtiAccidenteModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente = repositorioAccidente;
        }

        public IActionResult OnGet(int accidenteId)
        {
            accidente = repositorioAccidente.buscar(accidenteId);
            if (accidenteId == null)
            {
                return RedirectToPage("./NotFound");
            }
            else

                return Page();

        }

        public IActionResult OnPost()
        {
            accidente = repositorioAccidente.update(accidente);
            return Page();
        }
    }
}
