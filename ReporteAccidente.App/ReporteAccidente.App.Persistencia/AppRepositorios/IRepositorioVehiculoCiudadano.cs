using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioVehiculoCiudadano
    {
        IEnumerable<VehiculoCiudadano> GetAllVehiculoCiudadano();
        IEnumerable<VehiculoCiudadano> GetFiltroVehiculoCiudadano(int idCiudadano);
        VehiculoCiudadano AddVehiculoCiudadano(VehiculoCiudadano vehiculoCiudadano);
        VehiculoCiudadano UpdateVehiculoCiudadano(VehiculoCiudadano vehiculoCiudadano);
        void DeleteVehiculoCiudadano(int idVehiculoCiudadano);
        VehiculoCiudadano GetVehiculoCiudadano(int idVehiculoCiudadano);
        

    }

}