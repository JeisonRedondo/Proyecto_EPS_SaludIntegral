using System;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Consola
{
    class Program
    {
/// <summary>
/// Punto de Localizacion de Repositorios.
/// </summary>
        private static IRepository_Locations _repoLocations = new Repository_Locations();
        private static IRepository_Schedule _repoSchedule = new Repository_Schedule();
        private static IRepository_Patient _repoPatient = new Repository_Patient();
        private static IRepository_Medic _repoMedic = new Repository_Medic();
        static void Main(string[] args)
        {
        ///<return>
        ///Metodos para usar de CRUD por Entidades--Zona de ejecucion en consola.
        ///</return>
           Console.WriteLine("Hello World EF!");
           //AddPatient(); 
           //Find_Patient(3);
           //Show_Patient();
           Delete_Patient(3);
           //AddLocationsInPatient();

           //AddMedic();
           //Find_Medic(1);
           //Show_medics();
           //Delete_Medic(3);
           //AddLocationsInMedic();

           

           //AddSchedule();
           //Find_Schedule(1);
           //Show_Schedule();
           //Delete_Schedule(3);
           //Entrada de las Entidades deben ser VERIFICADAS en las funciones abajo descritas.
           //AddLocationsInSchedule();
           //AddMedicInSchedule();
           //AddPatientInSchedule();

           //AddLocations();
           //Find_Locations(1);
           //Show_Locations();
           //Delete_Locations(3);
        }
  
        ///<return>
        ///Medotos de Paciente.
        ///</return>

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
                EPS = "MiEPS",
            };
            _repoPatient.AddPatient(patient1);
        }

        private static void Find_Patient(int idPatient)
        {
            var patient1 = _repoPatient.GetPatient(idPatient);
            Console.WriteLine(patient1.Names+" "+patient1.Email);
        }

        private static void Show_Patient()
        {
            IEnumerable<Patient> Pacientes = _repoPatient.GetAllPatients();
            foreach (var patient in Pacientes)
            {
                Console.WriteLine(patient.Names+" "+patient.Email);
            }
        }

        private static void Delete_Patient(int Id_Patient)
        {
            _repoPatient.DeletePatients(Id_Patient);
            Console.WriteLine("Patient removed");
        }

        private static void AddLocationsInPatient()
        {
           var sede = _repoPatient.AddLocationsInPatient(2,1);
            Console.WriteLine(sede.Name_Location+" "+sede.Address);
        }

        ///<return>
        ///Medotos de Medico
        ///</return>
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
                Specialization = "cirujana",
                //Location = new Locations{Name_Location = "Sede Cali 2",Address = "Calle 1",City = "Cali",
                Location = _repoLocations.GetLocations(1)
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

        private static void AddLocationsInMedic()
        {
           var sede = _repoMedic.AddLocationsInMedic(1,1);
            Console.WriteLine(sede.Name_Location+" "+sede.Address);
        }


        ///<return>
        ///Medotos de Agendas
        ///</return>
        private static void AddSchedule()
        {
            var date = new Schedule
        
            {
                
                Date = new DateTime(2021, 11, 25),
                Note = "Primera NOta",
                Date_Status = "Activa",
                
            };
            _repoSchedule.AddSchedule(date);         

        }
        
        private static void Find_Schedule(int Id_Date)
        {
            var date = _repoSchedule.GetDate(Id_Date);
            Console.WriteLine(date.Date_Status+" "+date.Date.ToString());

        }

        private static void Show_Schedule()
        {
            IEnumerable<Schedule> Agendas = _repoSchedule.GetAllDates();
            foreach (var date in Agendas)
            {
                Console.WriteLine(date.Date_Status+" "+date.Date.ToString());
            }
        }

        private static void Delete_Schedule(int Id_Date)
        {
            _repoSchedule.DeleteSchedule(Id_Date);
            Console.WriteLine("Schedule removed");
        }

        ///<return>
        ///#########/Metodos de Agregacion para Entidades en Agenda/########
        ///</return>
        private static void AddLocationsInSchedule()
        {
           var sede = _repoSchedule.AddLocationsInSchedule(1,1);
            Console.WriteLine(sede.Name_Location+" "+sede.Address);
        }

        private static void AddMedicInSchedule()
        {
           var medico = _repoSchedule.AddMedicInSchedule(1,1);
            Console.WriteLine(medico.Names);
        }

        private static void AddPatientInSchedule()
        {
           var paciente = _repoSchedule.AddPatientInSchedule(1,1);
            Console.WriteLine(paciente.Names);
        }


        ///<return>
        ///Medotos de Sedes
        ///</return>
        private static void AddLocations()
        {
            var sede = new Locations
        
            {
               
                Name_Location = "SEDE:Cali2",
                Address = "Cll 4 + al norte que al sur",
                City = "Cali",
                
            };
            _repoLocations.AddLocations(sede);         

        }

        private static void Find_Locations(int Id_Sede)
        {
            var sede = _repoLocations.GetLocations(Id_Sede);
            Console.WriteLine(sede.Name_Location+" "+sede.Address);

        }

        private static void Show_Locations()
        {
            IEnumerable<Locations> Sedes = _repoLocations.GetAllLocations();
            foreach (var sede in Sedes)
            {
                Console.WriteLine(sede.Name_Location+" "+sede.Address);
            }
        }

        private static void Delete_Locations(int Id_Sede)
        {
            _repoLocations.DeleteLocations(Id_Sede);
            Console.WriteLine("Locations removed");
        }
    
        
    }
}
