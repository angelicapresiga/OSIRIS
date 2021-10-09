using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioAccidente
    {   
        
        IEnumerable<Accidente> Obtener();
        Accidente buscar(int AccidenteId);
        Accidente update(Accidente AccidenteActualizado);
        IEnumerable<Accidente> GetAllAccidentes();
        Accidente AddAccidente(Accidente accidente);
        Accidente UpdateAccidente(Accidente accidente);
        void DeleteAccidente(int idAccidente);
        Accidente GetAccidente(int idAccidente);
        

    }

}