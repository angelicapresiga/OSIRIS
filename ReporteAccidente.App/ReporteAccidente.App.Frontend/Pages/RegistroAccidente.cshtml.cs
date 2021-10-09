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
    public class RegistroAccidenteModel : PageModel
    {
        private readonly IRepositorioAccidente repositorioAccidente;

        public IEnumerable<Accidente> Accidentes{get;set;}

        public RegistroAccidenteModel(IRepositorioAccidente repositorioAccidente)
        {
            this.repositorioAccidente=repositorioAccidente;
        }

        public void OnGet()
        {
            Accidentes=repositorioAccidente.Obtener();

        }
    }
}
