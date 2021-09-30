using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioAgente:IRepositorioAgente
    {
      
        private readonly AppContext _appContext;
        public RepositorioAgente(AppContext appContext)
        {
            _appContext=appContext;
        }

        Agente IRepositorioAgente.AddAgente(Agente agente)
        {
            var agenteAdicionado = _appContext.Agentes.Add(agente);
            _appContext.SaveChanges();
            return agenteAdicionado.Entity;
        }
        void IRepositorioAgente.DeleteAgente(int idAgente)
        {
            var agenteEncontrado=_appContext.Agentes.FirstOrDefault(p => p.Id==idAgente);
            if(agenteEncontrado==null) 
            return;
            _appContext.Agentes.Remove(agenteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Agente> IRepositorioAgente.GetAllAgentes()
        {
            return _appContext.Agentes;

        }

        Agente IRepositorioAgente.GetAgente(int idAgente)
        {
            return _appContext.Agentes.FirstOrDefault(p => p.Id==idAgente);
        }

        Agente IRepositorioAgente.UpdateAgente(Agente agente)
        {

            var agenteEncontrado=_appContext.Agentes.FirstOrDefault(p => p.Id==agente.Id);
            if(agenteEncontrado!=null)
            {
                agenteEncontrado.Id=agente.Id;
                agenteEncontrado.Nombre=agente.Nombre;
                
                

                _appContext.SaveChanges();
            }
            return agenteEncontrado;
        }
        
    }


}