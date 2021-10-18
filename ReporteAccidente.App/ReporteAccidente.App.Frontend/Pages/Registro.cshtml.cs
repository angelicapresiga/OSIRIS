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
    public class RegistroModel : PageModel
    {
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        [BindProperty]
        public Accidente accidente { get; set; }
       
        public string Message { get; set; }
       
    }
}
