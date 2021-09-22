using Microsoft.EntityFrameworkCore;
using ReporteAccidente.App.Dominio;

namespace ReporteAccidente.App.Persistencia

{
    public class AppContext : DbContext
    {
        public DbSet<Accidente> Accidentes{get;set;}
        public DbSet<AccidenteCiudadano> AccidenteCiudadanos{get;set;}
        public DbSet<Agente> Agentes{get;set;}
        public DbSet<Ciudadano> Ciudadanos{get;set;}
        public DbSet<Vehiculo> Vehiculos{get;set;}
        public DbSet<VehiculoCiudadano> VehiculoCiudadanos{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ReporteAccidenteData");
            }

        }
    }
}

