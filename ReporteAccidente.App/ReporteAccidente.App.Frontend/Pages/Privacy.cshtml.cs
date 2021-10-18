using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ReporteAccidente.App.Persistencia;
using ReporteAccidente.App.Dominio;


namespace ReporteAccidente.App.Frontend.Pages
{
    public class PrivacyModel : PageModel
    {
        private static IRepositorioAgente _repoAgente = new RepositorioAgente(new Persistencia.AppContext());
        [BindProperty]
        public Agente agente { get; set; }
        public Agente validacion{get; set;}
        [TempData]
        public string Message { get; set; }
        public ActionResult Index(string message="")
        {
            Message=message;
            
            return Page();

        }

         public IActionResult OnPost()
        {   
            if(!ModelState.IsValid)
            {
                return Index("Llenar Campos correctamente");
            }
            if(agente.Id>0)
            {
                  
                validacion = _repoAgente.GetAgente(agente.Id);
                if(validacion.Id==agente.Id && validacion.Nombre==agente.Nombre)
                {
                    
                    return RedirectToPage("./BuscarAccidente");
                    
                }
                else
                  {  
                    
                    return Index("Id o Nombre Incorrecto");
                    
                  }
            }
            else
                return Index("Llenar Campos correctamente");
           
        }
       
      
    }
}
