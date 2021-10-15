using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia

{
    public interface IRepository_Locations
    {
        IEnumerable<Locations> GetAllLocations();

        Locations AddLocations(Locations Sede);

        Locations UpdateLocations(Locations Sede);

        void DeleteLocations(int idSede);

        Locations GetLocations(int idSede);
        
        
    
    }
}