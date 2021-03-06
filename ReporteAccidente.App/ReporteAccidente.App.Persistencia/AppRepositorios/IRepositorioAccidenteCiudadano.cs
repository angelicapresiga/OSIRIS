using System.Collections.Generic;
using ReporteAccidente.App.Dominio;

namespace ReporteAccidente.App.Persistencia
{


    public interface IRepositorioAccidenteCiudadano
    {
        
        IEnumerable<AccidenteCiudadano> GetAllAccidenteCiudadanos();
        IEnumerable<AccidenteCiudadano> GetFiltroAccidenteCiudadanos(int idCiudadano);
        AccidenteCiudadano AddAccidenteCiudadano(AccidenteCiudadano accidenteCiudadano);
        AccidenteCiudadano UpdateAccidenteCiudadano(AccidenteCiudadano accidenteCiudadano);
        void DeleteAccidenteCiudadano(int idAccidenteCiudadano);
        AccidenteCiudadano GetAccidenteCiudadano(int idAccidenteCiudadano);
        

    }

}
