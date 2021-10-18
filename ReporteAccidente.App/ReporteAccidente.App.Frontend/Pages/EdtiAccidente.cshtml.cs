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
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        [BindProperty]
        public Accidente accidente { get; set; }
        public EdtiAccidenteModel(IRepositorioAccidente repositorioAccidente )
        {
            this.repositorioAccidente=repositorioAccidente;
        }

        public IActionResult OnGet(int? accidenteId)
        {   
           
            if(accidenteId.HasValue)
            {
                 accidente = _repoAccidente.GetAccidente(accidenteId.Value);
            }
            else
            {
                accidente= new Accidente();
            }
            if (accidente == null)
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
            if(accidente.Id>0)
            {
                accidente = _repoAccidente.UpdateAccidente(accidente);
            }
            else
            {
                _repoAccidente.AddAccidente(accidente);
            }
            return Page();
        }
    }
}
