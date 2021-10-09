using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioCiudadano
    {
        IEnumerable<Ciudadano> Obtener();
        IEnumerable<Ciudadano> GetAllCiudadanos();
        Ciudadano AddCiudadano(Ciudadano ciudadano);
        Ciudadano UpdateCiudadano(Ciudadano ciudadano);
        void DeleteCiudadano(int idAccidente);
        Ciudadano GetCiudadano(int idAccidente);
    }

}