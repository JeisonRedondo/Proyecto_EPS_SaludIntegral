using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia
{
    public interface IRepository_Schedule
    {
     IEnumerable<Schedule> GetAllDates();
     
     Schedule AddSchedule(Schedule date);

     Schedule UpdateDate(Schedule date);

     void DeleteSchedule(int Id_Date);
     
     Schedule GetDate(int Id_Date);

    Locations AddLocationsInSchedule(int idCita, int idSede);

     Medic AddMedicInSchedule(int idCita, int idMedic);

    Patient AddPatientInSchedule(int idCita, int idPatient);

    }
}