using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public interface IRepository_Patient
    {
        IEnumerable<Patient> GetAllPatients();        

        Patient AddPatient(Patient Paciente);

        Patient UpdatePatient(Patient Paciente);

        void DeletePatients(int idPatient);

        Patient GetPatient(int idPatient);

        Locations AddLocationsInPatient(int idPaciente , int idSede);

        
    
    }
}