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




        Locations IRepository_Patient.AddLocationsInPatient(int idPaciente, int idSede)
        {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado != null)
            {
                var sedeEncontrada = _appContext.Sedes.FirstOrDefault(m => m.Id == idSede);
                if (sedeEncontrada != null)
                {
                    pacienteEncontrado.Location = sedeEncontrada;
                    _appContext.SaveChanges();
                }
                return sedeEncontrada;
            }
            return null;

        }
        
        //codigo de prueba 16 10 2021

        /*Medic IRepository_Patient.AssignMedic(int idPatient, int Id_Medic)
        {
            var patientFound = _appContext.Pacientes.FirstOrDefault(p => p.Id == idPatient);
            if (patientFound != null)
            {
                var medicFound = _appContext.Medicos.FirstOrDefault(m => m.Id == Id_Medic);
                if (medicFound != null)
                {
                    patientFound.Medic = medicFound;
                    _appContext.SaveChanges();
                }
                return medicFound;
            }
            return null;
        } */





    }



}