using System;
using System.Collections.Generic;
using System.Linq;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public interface IRepositoriesPatient
    {
        IEnumerable<Patient> GetAllPacientes();
        Patient AddPatient(Patient Paciente);
        Patient UpdatePatient(Patient Paciente);
        void DeletePatient(int idPatient);
        Patient GetPatient(int idPatient);
    
    }
}