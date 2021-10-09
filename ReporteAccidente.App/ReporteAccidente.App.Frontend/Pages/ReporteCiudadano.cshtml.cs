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
    public class ReporteCiudadanoModel : PageModel
    {
        private readonly IRepositorioCiudadano repositoriociudadano;

        public IEnumerable<Ciudadano> Ciudadanos{get;set;}

        public ReporteCiudadanoModel(IRepositorioCiudadano repositoriociudadano)
        {
            this.repositoriociudadano=repositoriociudadano;
        }

        public void OnGet()
        {
             Ciudadanos=repositoriociudadano.Obtener();
        }
    }
}
