using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioAccidente:IRepositorioAccidente
    {
        
        List<Accidente> Accidentes1;
        public RepositorioAccidente()
        {
            Accidentes1= new List<Accidente>()
            {
                new Accidente{Id=1 , IdAgente=525, Latitud="-13", Longitud="-25", Direccion="cll 127 b bis 52-68", Hora="22:00"},
                new Accidente{Id=2 , IdAgente=365, Latitud="83", Longitud="-45", Direccion="cll 12 sur 45-9", Hora="10:00"},
                new Accidente{Id=3 , IdAgente=897, Latitud="23", Longitud="15", Direccion="crr 56 occidente -58", Hora="05:00"}
            };
        }
        public Accidente update(Accidente accidenteActualizado)
        {
            var accidente= Accidentes1.SingleOrDefault(r => r.Id==accidenteActualizado.Id);
            if(accidente!=null)
            {
                accidente.Id=accidenteActualizado.Id;
                accidente.IdAgente=accidenteActualizado.IdAgente;
                accidente.Latitud=accidenteActualizado.Latitud;
                accidente.Longitud=accidenteActualizado.Longitud;
                accidente.Direccion=accidenteActualizado.Direccion;
                accidente.Hora=accidenteActualizado.Hora;
            }
            return accidente;
        }
        public IEnumerable<Accidente> Obtener()
        {
            return Accidentes1;
        }

        public Accidente buscar(int AccidenteId)
        {
            return Accidentes1.SingleOrDefault(s=> s.Id==AccidenteId);
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