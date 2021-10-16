using System.Collections.Generic;
using System.Linq;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public class Repository_Schedule : IRepository_Schedule
    {
        /// <summary>
        /// Referencia al contexto de Agenda
        /// </summary>
        //private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        // <param name="appContext"></param>//

        private readonly AppContext _appContext = new AppContext();
        
        Schedule IRepository_Schedule.AddSchedule(Schedule date)
        {
            var Added_Date = _appContext.Agendas.Add(date);
            _appContext.SaveChanges();
            return Added_Date.Entity;

        }

        IEnumerable<Schedule> IRepository_Schedule.GetAllDates()
        {
            return _appContext.Agendas;
        }

        Schedule IRepository_Schedule.GetDate(int Id_Date)
        {
            return _appContext.Agendas.FirstOrDefault(m => m.Id == Id_Date);
        }

        Schedule IRepository_Schedule.UpdateDate(Schedule date)
        {
            var Found_Date = _appContext.Agendas.FirstOrDefault(m => m.Id == date.Id);
            if (Found_Date != null)
            {
                Found_Date.Location = date.Location;
                Found_Date.Medic = date.Medic;
                Found_Date.Patient = date.Patient;
                Found_Date.Date = date.Date;
                Found_Date.Note = date.Note;
                Found_Date.Date_Status = date.Date_Status;

                _appContext.SaveChanges();

            }
            return Found_Date;
        }

        void IRepository_Schedule.DeleteSchedule(int Id_Date)
        {
            var Found_Schedule = _appContext.Agendas.FirstOrDefault(m => m.Id == Id_Date);
            if (Found_Schedule == null)
                return;
            _appContext.Agendas.Remove(Found_Schedule);
            _appContext.SaveChanges();
        }

        Locations IRepository_Schedule.AddLocationsInSchedule(int idCita, int idSede)
        {
            var citaEncontrada = _appContext.Agendas.FirstOrDefault(p => p.Id == idCita);
            if (citaEncontrada != null)
            {
                var sedeEncontrada = _appContext.Sedes.FirstOrDefault(m => m.Id == idSede);
                if (sedeEncontrada != null)
                {
                    citaEncontrada.Location = sedeEncontrada;
                    _appContext.SaveChanges();
                }
                return sedeEncontrada;
            }
            return null;

        }

        Medic IRepository_Schedule.AddMedicInSchedule(int idCita, int idMedic)
        {
            var citaEncontrada = _appContext.Agendas.FirstOrDefault(p => p.Id == idCita);
            if (citaEncontrada != null)
            {
                var medicoEncontrado = _appContext.Medicos.FirstOrDefault(m => m.Id == idMedic);
                if (medicoEncontrado != null)
                {
                    citaEncontrada.Medic = medicoEncontrado;
                    _appContext.SaveChanges();
                }
                return medicoEncontrado;
            }
            return null;

        }

        Patient IRepository_Schedule.AddPatientInSchedule(int idCita, int idPatient)
        {
            var citaEncontrada = _appContext.Agendas.FirstOrDefault(p => p.Id == idCita);
            if (citaEncontrada != null)
            {
                var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(m => m.Id == idPatient);
                if (pacienteEncontrado != null)
                {
                    citaEncontrada.Patient = pacienteEncontrado;
                    _appContext.SaveChanges();
                }
                return pacienteEncontrado;
            }
            return null;

        }
    }
}