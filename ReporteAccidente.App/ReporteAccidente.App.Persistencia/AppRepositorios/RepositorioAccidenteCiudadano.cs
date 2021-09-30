using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioAccidenteCiudadano:IRepositorioAccidenteCiudadano
    {
      
        private readonly AppContext _appContext;
        public RepositorioAccidenteCiudadano(AppContext appContext)
        {
            _appContext=appContext;
        }

        AccidenteCiudadano IRepositorioAccidenteCiudadano.AddAccidenteCiudadano(AccidenteCiudadano accidenteCiudadano)
        {
            var accidenteCiudadanoAdicionado = _appContext.AccidenteCiudadanos.Add(accidenteCiudadano);
            _appContext.SaveChanges();
            return accidenteCiudadanoAdicionado.Entity;
        }
        void IRepositorioAccidenteCiudadano.DeleteAccidenteCiudadano(int idAccidenteCiudadano)
        {
            var accidenteCiudadanoEncontrado=_appContext.AccidenteCiudadanos.FirstOrDefault(p => p.Id==idAccidenteCiudadano);
            if(accidenteCiudadanoEncontrado==null) 
            return;
            _appContext.AccidenteCiudadanos.Remove(accidenteCiudadanoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<AccidenteCiudadano> IRepositorioAccidenteCiudadano.GetAllAccidenteCiudadanos()
        {
            return _appContext.AccidenteCiudadanos;

        }

        AccidenteCiudadano IRepositorioAccidenteCiudadano.GetAccidenteCiudadano(int idAccidenteCiudadano)
        {
            return _appContext.AccidenteCiudadanos.FirstOrDefault(p => p.Id==idAccidenteCiudadano);
        }

        AccidenteCiudadano IRepositorioAccidenteCiudadano.UpdateAccidenteCiudadano(AccidenteCiudadano accidenteCiudadano)
        {

            var accidenteCiudadanoEncontrado=_appContext.AccidenteCiudadanos.FirstOrDefault(p => p.Id==accidenteCiudadano.Id);
            if(accidenteCiudadanoEncontrado!=null)
            {
                accidenteCiudadanoEncontrado.Id=accidenteCiudadano.Id;
                accidenteCiudadanoEncontrado.IdAccidente=accidenteCiudadano.IdAccidente;
                accidenteCiudadanoEncontrado.IdCiudadano=accidenteCiudadano.IdCiudadano;
                

                _appContext.SaveChanges();
            }
            return accidenteCiudadanoEncontrado;
        }
        
    }


}