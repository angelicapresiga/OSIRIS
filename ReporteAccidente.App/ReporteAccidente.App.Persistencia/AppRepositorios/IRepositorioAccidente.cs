using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioAccidente
    {   
        
     
        IEnumerable<Accidente> GetAllAccidentes();
        Accidente AddAccidente(Accidente accidente);
        Accidente UpdateAccidente(Accidente accidente);
        void DeleteAccidente(int idAccidente);
        Accidente GetAccidente(int idAccidente);
        

    }

}