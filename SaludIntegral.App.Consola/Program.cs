using System;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Consola
{
    class Program
    {
        private static IRepositoriesPatient _repoPatient = new RepositoriesPatient(new Persistencia.AppContext());
        private static IRepository_Medic _repoMedic = new Repository_Medic(new Persistencia.AppContext());
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World EF!");
           //AddPatient(); 
           //SearchPatient(3);

           AddMedic();
           //Find_Medic(1);
           //Delete_Medic(3);
           //Show_medics();
        }

        private static void AddPatient()
        {
            var patient1 = new Patient
            {
                Identification = "0001",
                Names = "Luis Quitero",
                DateOfBirth = new DateTime(1987, 11, 25),
                Gender = "Male",
                Phone_number = "3113456789",
                Email = "Juroqeer@mail.com",

            };
            _repoPatient.AddPatient(patient1);
        }

        private static void SearchPatient(int idPatient)
        {
            var patient1 = _repoPatient.GetPatient(idPatient);
            Console.WriteLine(patient1.Names+" "+patient1.Email);
        }

        //--------------------------------Codigo de Medico---------------------------------------------------------------
private static void AddMedic()
        {
            var medic = new Medic

            {
                Identification = "0001",
                Names = "tania ospina",  
                DateOfBirth = new DateTime(1994, 11, 25),
                Gender = "femenino",
                Phone_number = "3209637410",
                Email = "luisao@gmail.com",
                Specialization = "cirujana"
                //Locations = "Cartagena"

            };
            _repoMedic.AddMedic(medic);         

        }
        private static void Find_Medic(int Medic)
        {
            var medic = _repoMedic.GetMedic(Medic);
            Console.WriteLine(medic.Names);

        }

            private static void Show_medics()
        {
            IEnumerable<Medic> Medicos = _repoMedic.GetAllMedics();
            foreach (var medic in Medicos)
            {
                Console.WriteLine(medic.Names);
            }
        }
        private static void Delete_Medic(int Id_Medic)
        {
            _repoMedic.DeleteMedic(Id_Medic);
            Console.WriteLine("Medic removed");
        }


    }
}
