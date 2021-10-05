using System;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Consola
{
    class Program
    {
        private static IRepository_Medic _repoMedic = new Repository_Medic(new Persistencia.AppContext());
        static void Main(string[] args)
        {
          
           //AddMedic();
           //Find_Medic(1);
           //Delete_Medic(3);
           Show_medics();

           Console.WriteLine("se ejecuto el programa");

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

        private static void Show_medics()
        {
            IEnumerable<Medic> Medicos = _repoMedic.GetAllMedics();
            foreach (var medic in Medicos)
            {
                Console.WriteLine(medic.Names);
            }
        }



    



    }

}

