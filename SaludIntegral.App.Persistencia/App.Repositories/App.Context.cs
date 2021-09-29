using Microsoft.EntityFrameworkCore;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Person> Personas { get; set;}
       public DbSet<Patient> Pacientes {get;set;}
       public DbSet<Medic> Medicos {get;set;}
       
      public DbSet<Schedule> Agendas {get;set;}
        public DbSet<EPS> EPSs {get;set;}
       public DbSet<IPS> IPSs {get;set;}
        public DbSet<Locations> Sedes {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EPSsaludintegral.Data");
           }
       }


       //COdigo de conexion para la base de datos:
   }  // dotnet ef migrations add Inicial4 --startup-project ..\SaludIntegral.App.Consola\

      //Codigo de actualizacion de la base de datos:
      //dotnet ef database update --startup-project ..\SaludIntegral.App.Consola\
}