using System;
using ReporteAccidente.App.Dominio;
using ReporteAccidente.App.Persistencia;

namespace ReporteAccidente.App.Consola 
{
    class Program
    {
        private static IRepositorioAccidente _repoAccidente = new RepositorioAccidente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Entidad Framework!");
            AddAccidente();
        }

        private static void  AddAccidente()
        {
            var accidente = new Accidente{

                IdAgente=1,Latitud="-13",
                Longitud="05",
                Direccion="cll 127 b Bis # 52-68",
                Fecha="9 de noviembre 2021",
                Hora="20:00"
            };
            _repoAccidente.AddAccidente(accidente);
        }
    }
}
