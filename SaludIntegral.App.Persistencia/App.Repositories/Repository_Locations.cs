using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SaludIntegral.App.Dominio;


namespace SaludIntegral.App.Persistencia
{
    public class Repository_Locations :IRepository_Locations
    {
        private readonly AppContext _appContext= new AppContext();
        
        Locations IRepository_Locations.AddLocations(Locations Sede)
        {
            var SedeAdicionada = _appContext.Sedes.Add(Sede);
            
            _appContext.SaveChanges();
            return SedeAdicionada.Entity;
        }

        void IRepository_Locations.DeleteLocations(int idSede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault(p => p.Id == idSede);

            if (sedeEncontrada == null)
            return;

            _appContext.Sedes.Remove(sedeEncontrada);
            _appContext.SaveChanges();

        }

        IEnumerable<Locations> IRepository_Locations.GetAllLocations()
        {
            return _appContext.Sedes;
        }

        Locations IRepository_Locations.GetLocations(int idSede)
        {
            return _appContext.Sedes.FirstOrDefault(p => p.Id == idSede);
        }

        Locations IRepository_Locations.UpdateLocations(Locations Sede)
        {
            var sedeEncontrada = _appContext.Sedes.FirstOrDefault( p => p.Id == Sede.Id);

            if (sedeEncontrada != null)
            {
                sedeEncontrada.Name_Location = Sede.Name_Location;
                sedeEncontrada.Address = Sede.Address;
                sedeEncontrada.City = Sede.City;
                
                
                _appContext.SaveChanges();
            }
            return sedeEncontrada;
        }

         
    }
}