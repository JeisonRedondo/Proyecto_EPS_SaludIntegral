using System;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Consola
{
    class Program
    {
        private static IRepositoriesPatient _repoPatient = new RepositoriesPatient(new Persistencia.AppContext());
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World EF!");
           AddPatient(); 
           //SearchPatient(3);
        }

        private static void AddPatient()
        {
            var patient1 = new Patient
            {
                
                Names = "Ana rodrigez",
                Age = "25",
                Gender = "Female",
                Phone_number = "3113456789",
                Email = "anaeer@mail.com",

            };
            _repoPatient.AddPatient(patient1);
        }

        private static void SearchPatient(int idPatient)
        {
            var patient1 = _repoPatient.GetPatient(idPatient);
            Console.WriteLine(patient1.Names+" "+patient1.Email);
        }

    }
}
