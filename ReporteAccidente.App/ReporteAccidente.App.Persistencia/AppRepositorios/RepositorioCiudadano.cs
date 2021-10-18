using System.Collections.Generic;
using ReporteAccidente.App.Dominio;
using System.Linq;

namespace ReporteAccidente.App.Persistencia
{

    public class RepositorioCiudadano:IRepositorioCiudadano
    {
        List<Ciudadano> ciudadanos;
        public RepositorioCiudadano()
        {
            
        }  
        private readonly AppContext _appContext;
        public RepositorioCiudadano(AppContext appContext)
        {
            _appContext=appContext;
        }

        Ciudadano IRepositorioCiudadano.AddCiudadano(Ciudadano ciudadano)
        {
            var CiudadanoAdicionado = _appContext.Ciudadanos.Add(ciudadano);
            _appContext.SaveChanges();
            return CiudadanoAdicionado.Entity;
        }
        void IRepositorioCiudadano.DeleteCiudadano(int idCiudadano)
        {
            var CiudadanoEncontrado=_appContext.Ciudadanos.FirstOrDefault(p => p.Id==idCiudadano);
            if(CiudadanoEncontrado==null) 
            return;
            _appContext.Ciudadanos.Remove(CiudadanoEncontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Ciudadano> IRepositorioCiudadano.GetAllCiudadanos()
        {
            return _appContext.Ciudadanos;

        }

        Ciudadano IRepositorioCiudadano.GetCiudadano(int idCiudadano)
        {
            return _appContext.Ciudadanos.FirstOrDefault(p => p.Id==idCiudadano);
        }

        Ciudadano IRepositorioCiudadano.UpdateCiudadano(Ciudadano ciudadano)
        {

            var CiudadanoEncontrado=_appContext.Ciudadanos.FirstOrDefault(p => p.Id==ciudadano.Id);
            if(CiudadanoEncontrado!=null)
            {
                CiudadanoEncontrado.Id=ciudadano.Id;
                CiudadanoEncontrado.Nombre=ciudadano.Nombre;
                CiudadanoEncontrado.Sexo=ciudadano.Sexo;
                CiudadanoEncontrado.Edad=ciudadano.Edad;
                CiudadanoEncontrado.TipoAgenteVial=ciudadano.TipoAgenteVial;
                _appContext.SaveChanges();
            }
            return CiudadanoEncontrado;
        }
        
    }


}