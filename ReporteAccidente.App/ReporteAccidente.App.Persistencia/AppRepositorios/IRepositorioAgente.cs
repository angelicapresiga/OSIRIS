
using System.Collections.Generic;
using ReporteAccidente.App.Dominio;

namespace ReporteAccidente.App.Persistencia
{
    public interface IRepositorioAgente
    {
        IEnumerable<Agente> GetAllAgentes();
        Agente AddAgente(Agente agente);
        Agente UpdateAgente(Agente agente);
        void DeleteAgente(int idAgente);
        Agente GetAgente(int idAgente);
        

    }

}