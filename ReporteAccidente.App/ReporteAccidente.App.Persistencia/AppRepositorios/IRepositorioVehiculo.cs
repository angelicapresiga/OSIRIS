using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioVehiculo
    {   
    
        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int idAccidente);
        Vehiculo GetVehiculo(int idAccidente);
    }

}