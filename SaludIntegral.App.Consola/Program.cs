using System;
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
           SearchPatient(3);

            //AddMedic();
           //Find_Medic(1);
           //Delete_Medic(3);
           //Show_medics();

        }

        private static void AddPatient()
        {
            var patient1 = new Patient
            {
                Id = 4,
                Names = "Juan Robles",
                Age = "34",
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


       
        //preguntar si la  fecha es mejor con data time
        private static void AddMedic()
        {
            var medic = new Medic

            {
                
                Names = "tania ospina",  
                Age = "34",
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

        private static void Delete_Medic(int Id_Medic)
        {
            _repoMedic.DeleteMedic(Id_Medic);
            Console.WriteLine("Medic removed");
        }

       /* private static void Show_medics()
        {
            IEnumerable<Medic> Medicos = _repoMedic.GetAllMedics();
            foreach (var medic in Medicos)
            {
                Console.WriteLine(medic.Names);
            }
        }*/


    }
}
