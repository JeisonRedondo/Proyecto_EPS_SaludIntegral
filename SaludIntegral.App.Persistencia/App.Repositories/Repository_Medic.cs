using System.Collections.Generic;
using System.Linq;
using SaludIntegral.App.Dominio;


namespace SaludIntegral.App.Persistencia

{
    public class Repository_Medic : IRepository_Medic
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public Repository_Medic(AppContext appContext)
        {
            _appContext = appContext;
        }



        Medic IRepository_Medic.AddMedic(Medic medic)
        {
            var Added_Medic = _appContext.Medicos.Add(medic);
            _appContext.SaveChanges();
            return Added_Medic.Entity;            

        }

        void IRepository_Medic.DeleteMedic(int Id_Medic)
        {
            var Found_Medic = _appContext.Medicos.FirstOrDefault(m => m.Id == Id_Medic);
            if (Found_Medic == null)
            return;
            _appContext.Medicos.Remove(Found_Medic);
            _appContext.SaveChanges();
        }

        
        IEnumerable<Medic> IRepository_Medic.GetAllMedics()
        {
            return _appContext.Medicos;
        }


        Medic IRepository_Medic.GetMedic(int Id_Medic)
        {
            return _appContext.Medicos.FirstOrDefault(m => m.Id == Id_Medic);
        }


        Medic IRepository_Medic.UpdateMedic(Medic medic)
        {
            var Found_Medic  = _appContext.Medicos.FirstOrDefault(m => m.Id == medic.Id);
            if (Found_Medic != null)
            {
                Found_Medic.Identification = medic.Identification;
                Found_Medic.Names = medic.Names;
                Found_Medic.DateOfBirth = medic.DateOfBirth;
                Found_Medic.Gender = medic.Gender;
                Found_Medic.Phone_number = medic.Phone_number;
                Found_Medic.Email = medic.Email;
                Found_Medic.Location = medic.Location;
                Found_Medic.Specialization = medic.Specialization;
                Found_Medic.Password = medic.Password;         

                _appContext.SaveChanges();

            }
            return Found_Medic;
        }

        Locations IRepository_Patient.AddLocationsInMedic(int idMedico, int idSede)
        {
            var medicoEncontrado = _appContext.Medicos.FirstOrDefault(p => p.Id == idMedico);
            if (medicoEncontrado != null)
            {
                var sedeEncontrada = _appContext.Sedes.FirstOrDefault(m => m.Id == idSede);
                if (sedeEncontrada != null)
                {
                    medicoEncontrado.Location = sedeEncontrada;
                    _appContext.SaveChanges();
                }
                return sedeEncontrada;
            }
            return null;

        }

 
    }





}
