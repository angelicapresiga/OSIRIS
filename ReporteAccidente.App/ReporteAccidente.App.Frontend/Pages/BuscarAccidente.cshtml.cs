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
  
    public class BuscarAccidenteModel : PageModel
    {
     
    [BindProperty]
    public Accidente Acci { get; set; }
    
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        [BindProperty]
        public Accidente accidente { get; set; }
        private static IRepositorioAgente _repoAgente = new RepositorioAgente(new Persistencia.AppContext());
        [BindProperty]
        public Agente agente { get; set; }

        private static IRepositorioAccidenteCiudadano _repoAcciCiuda = new RepositorioAccidenteCiudadano(new Persistencia.AppContext());
        [BindProperty]
        public AccidenteCiudadano AcciCuida { get; set; }

        public IEnumerable<AccidenteCiudadano> AcciCiudas{get;set;}

        private static IRepositorioCiudadano _repoCiuda = new RepositorioCiudadano(new Persistencia.AppContext());
        [BindProperty]
        public AccidenteCiudadano ciudadano { get; set; }

        public List <Ciudadano> ciudadanos = new List<Ciudadano>();

        private static IRepositorioVehiculo _repoVehi = new RepositorioVehiculo(new Persistencia.AppContext());
        [BindProperty]
        public Vehiculo vehiculo { get; set; }

        public List <Vehiculo> vehiculos = new List<Vehiculo>();

        private static IRepositorioVehiculoCiudadano _repoVehiciu = new RepositorioVehiculoCiudadano(new Persistencia.AppContext());
       
        public List <VehiculoCiudadano> Vehiciudas = new List<VehiculoCiudadano>();
        public IActionResult OnPost()
        {
             accidente = _repoAccidente.GetAccidente(accidente.Id);
           
           
            if (accidente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
               {    
                   agente = _repoAgente.GetAgente(accidente.Id);
                   AcciCiudas=_repoAcciCiuda.GetFiltroAccidenteCiudadanos(accidente.Id);
                foreach (var acciciudadano in AcciCiudas)
                {
                    ciudadanos.Add(_repoCiuda.GetCiudadano(acciciudadano.IdCiudadano));
                    

                }
                foreach(var vehiculociu in ciudadanos)
                {
                        Vehiciudas.Add((_repoVehiciu.GetVehiculoCiudadano(vehiculociu.Id)));
                }
                foreach(var vehi in Vehiciudas )   
                {
                    vehiculos.Add(_repoVehi.GetVehiculo(vehi.IdVehiculo));
                }
                   return Page();
               }
                

            
        }
    }
}
