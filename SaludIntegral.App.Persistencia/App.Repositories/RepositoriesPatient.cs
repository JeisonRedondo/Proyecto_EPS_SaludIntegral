using System.Collections.Generic;
using System.Linq;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public class RepositoriesPatient :IRepositoriesPatient
    {
        private readonly AppContext _appContext;

        public RepositoriesPatient(AppContext appContext)
        {
            _appContext = appContext;
        }

        Patient IRepositoriesPatient.AddPatient(Patient Paciente)
        {
            var PacienteAdicionado = _appContext.Pacientes.Add(Paciente);
            
            _appContext.SaveChanges();
            return PacienteAdicionado.Entity;
        }

          void IRepositoriesPatient.DeletePatient(int idPatient)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPatient);

            if (pacienteEncontrado == null)
            return;

            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();

        }  

        IEnumerable<Patient> IRepositoriesPatient.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }

        Patient IRepositoriesPatient.GetPatient(int idPatient)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPatient);
        }

        Patient IRepositoriesPatient.UpdatePatient(Patient Paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault( p => p.Id == Paciente.Id);

            if (pacienteEncontrado != null)
            {
                pacienteEncontrado.Identification = Paciente.Identification;
                pacienteEncontrado.Names = Paciente.Names;
                pacienteEncontrado.DateOfBirth = Paciente.DateOfBirth;
                pacienteEncontrado.Gender = Paciente.Gender;
                pacienteEncontrado.Phone_number = Paciente.Phone_number;
                pacienteEncontrado.Email = Paciente.Email;
                pacienteEncontrado.Location = Paciente.Location;
                pacienteEncontrado.EPS = Paciente.EPS;
                pacienteEncontrado.Password = Paciente.Password;
                
                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }



    }



}