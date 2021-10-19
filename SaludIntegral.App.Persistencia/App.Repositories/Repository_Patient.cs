using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public class Repository_Patient : IRepository_Patient
    {

        private readonly AppContext _appContext = new AppContext();

        Patient IRepository_Patient.AddPatient(Patient Paciente)
        {
            var PacienteAdicionado = _appContext.Pacientes.Add(Paciente);

            _appContext.SaveChanges();
            return PacienteAdicionado.Entity;
        }

        void IRepository_Patient.DeletePatients(int idPatient)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPatient);

            if (pacienteEncontrado == null)
                return;

            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();

        }

        IEnumerable<Patient> IRepository_Patient.GetAllPatients()
        {
            return _appContext.Pacientes;
        }

        Patient IRepository_Patient.GetPatient(int idPatient)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPatient);
        }

        Patient IRepository_Patient.UpdatePatient(Patient Paciente)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == Paciente.Id);

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
        IEnumerable<Patient> IRepository_Patient.SearchPatiens(string name)
            {
                return _appContext.Pacientes
                .Where(p => p.Identification.Contains(name));
            }
         IEnumerable<Patient> IRepository_Patient.GetPatientLocation(int locacion)
        {
            return _appContext.Pacientes
                        .Where(p => p.Location ==(Locations)locacion)
                        .ToList();
<<<<<<< HEAD
        }
        IEnumerable<Patient> IRepository_Patient.SearchPatiensbyEmail(string Email)
            {
                return _appContext.Pacientes
                .Where(p => p.Email.Contains(Email));
            }
        Patient IRepository_Patient.SearchPatiensbyEmail2(string Email)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Email == Email);

            
            return pacienteEncontrado;
=======
>>>>>>> 59b8786f6a3e0fd0c76ad1fb83f5d0a26c93351c
        }



        






    }



}