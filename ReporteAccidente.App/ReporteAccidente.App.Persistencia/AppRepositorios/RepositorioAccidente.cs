using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioAccidente:IRepositorioAccidente
    {
        List<Accidente> accidentes;
        public RepositorioAccidente()
        {
            
        }
       
        private readonly AppContext _appContext;
        public RepositorioAccidente(AppContext appContext)
        {
            _appContext=appContext;
        }

        Accidente IRepositorioAccidente.AddAccidente(Accidente accidente)
        {
            var accidenteAdicionado = _appContext.Accidentes.Add(accidente);
            _appContext.SaveChanges();
            return accidenteAdicionado.Entity;
        }
        void IRepositorioAccidente.DeleteAccidente(int idAccidente)
        {
            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(p => p.Id==idAccidente);
            if(accidenteEncontrado==null) 
            return;
            _appContext.Accidentes.Remove(accidenteEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Accidente> IRepositorioAccidente.GetAllAccidentes()
        {
            return _appContext.Accidentes;

        }

        Accidente IRepositorioAccidente.GetAccidente(int idAccidente)
        {
            return _appContext.Accidentes.FirstOrDefault(p => p.Id==idAccidente);
        }

        Accidente IRepositorioAccidente.UpdateAccidente(Accidente accidente)
        {

            var accidenteEncontrado=_appContext.Accidentes.FirstOrDefault(p => p.Id==accidente.Id);
            if(accidenteEncontrado!=null)
            {
                accidenteEncontrado.Id=accidente.Id;
                accidenteEncontrado.IdAgente=accidente.IdAgente;
                accidenteEncontrado.Latitud=accidente.Latitud;
                accidenteEncontrado.Longitud=accidente.Longitud;
                accidenteEncontrado.Direccion=accidente.Direccion;
                accidenteEncontrado.Fecha=accidente.Fecha;
                accidenteEncontrado.Hora=accidente.Hora;

                _appContext.SaveChanges();
            }
            return accidenteEncontrado;
        }
        
    }


}