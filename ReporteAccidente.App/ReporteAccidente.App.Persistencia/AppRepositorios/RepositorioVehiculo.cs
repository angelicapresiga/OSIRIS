using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioVehiculo:IRepositorioVehiculo
    {
        
        private readonly AppContext _appContext;
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext=appContext;
        }

        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
        {
            var vehiculoAdicionado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return vehiculoAdicionado.Entity;
        }
        void IRepositorioVehiculo.DeleteVehiculo(int idVehiculo)
        {
            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(p => p.Id==idVehiculo);
            if(vehiculoEncontrado==null) 
            return;
            _appContext.Vehiculos.Remove(vehiculoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;

        }

        Vehiculo IRepositorioVehiculo.GetVehiculo(int idVehiculo)
        {
            return _appContext.Vehiculos.FirstOrDefault(p => p.Id==idVehiculo);
        }

        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo vehiculo)
        {

            var vehiculoEncontrado=_appContext.Vehiculos.FirstOrDefault(p => p.Id==vehiculo.Id);
            if(vehiculoEncontrado!=null)
            {
                vehiculoEncontrado.Id=vehiculo.Id;
                vehiculoEncontrado.Placa=vehiculo.Placa;
                vehiculoEncontrado.Marca=vehiculo.Marca;
                vehiculoEncontrado.Modelo=vehiculo.Modelo;
                

                _appContext.SaveChanges();
            }
            return vehiculoEncontrado;
        }
        
    }


}