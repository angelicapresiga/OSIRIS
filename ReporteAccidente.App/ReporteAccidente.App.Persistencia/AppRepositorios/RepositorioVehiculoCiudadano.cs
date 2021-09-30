using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioVehiculoCiudadano:IRepositorioVehiculoCiudadano
    {
      
        private readonly AppContext _appContext;
        public RepositorioVehiculoCiudadano(AppContext appContext)
        {
            _appContext=appContext;
        }

        VehiculoCiudadano IRepositorioVehiculoCiudadano.AddVehiculoCiudadano(VehiculoCiudadano vehiculoCiudadano)
        {
            var vehiculoCiudadanoAdicionado = _appContext.VehiculoCiudadanos.Add(vehiculoCiudadano);
            _appContext.SaveChanges();
            return vehiculoCiudadanoAdicionado.Entity;
        }
        void IRepositorioVehiculoCiudadano.DeleteVehiculoCiudadano(int idVehiculoCiudadano)
        {
            var vehiculoCiudadanoEncontrado=_appContext.VehiculoCiudadanos.FirstOrDefault(p => p.Id==idVehiculoCiudadano);
            if(vehiculoCiudadanoEncontrado==null) 
            return;
            _appContext.VehiculoCiudadanos.Remove(vehiculoCiudadanoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<VehiculoCiudadano> IRepositorioVehiculoCiudadano.GetAllVehiculoCiudadano()
        {
            return _appContext.VehiculoCiudadanos;

        }

        VehiculoCiudadano IRepositorioVehiculoCiudadano.GetVehiculoCiudadano(int idVehiculoCiudadano)
        {
            return _appContext.VehiculoCiudadanos.FirstOrDefault(p => p.Id==idVehiculoCiudadano);
        }

        VehiculoCiudadano IRepositorioVehiculoCiudadano.UpdateVehiculoCiudadano(VehiculoCiudadano vehiculoCiudadano)
        {

            var vehiculoCiudadanoEncontrado=_appContext.VehiculoCiudadanos.FirstOrDefault(p => p.Id==vehiculoCiudadano.Id);
            if(vehiculoCiudadanoEncontrado!=null)
            {
                vehiculoCiudadanoEncontrado.Id=vehiculoCiudadano.Id;
                vehiculoCiudadanoEncontrado.IdVehiculo=vehiculoCiudadano.IdVehiculo;
                vehiculoCiudadanoEncontrado.IdCiudadano=vehiculoCiudadano.IdCiudadano;
                

                _appContext.SaveChanges();
            }
            return vehiculoCiudadanoEncontrado;
        }
        
    }


}