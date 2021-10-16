using Microsoft.EntityFrameworkCore;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Persistencia
{
   public class AppContext : DbContext
   {
        public DbSet<Person> Personas { get; set;}
        public DbSet<Patient> Pacientes {get;set;}
        public DbSet<Medic> Medicos {get;set;}
        public DbSet<Schedule> Agendas {get;set;}
        public DbSet<Locations> Sedes {get;set;}
        

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = New_Salud_Integral");
               //.UseSqlServer("Initial Catalog=SaludIntegral; Data Source=JeisonDB; Integrated Security=true");

               // conexion linux jose
               //.UseSqlServer("Data Source =.; Initial Catalog = prelinux ;uid=SA ;pwd=123456aZ");
           }
       }


       //COdigo de conexion para la base de datos:
   }  // dotnet ef migrations add Inicial --startup-project ..\SaludIntegral.App.Consola\

      //Codigo de actualizacion de la base de datos:
      //dotnet ef database update --startup-project ..\SaludIntegral.App.Consola\
}