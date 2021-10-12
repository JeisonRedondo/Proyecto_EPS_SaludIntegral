using System.Collections.Generic;
using SaludIntegral.App.Dominio;

namespace SaludIntegral.App.Persistencia


{
    public interface IRepository_Medic
    {
     IEnumerable<Medic> GetAllMedics();
     
     Medic AddMedic(Medic medic);

     Medic UpdateMedic(Medic medic);

     void DeleteMedic(int Id_Medic);
     
     Medic GetMedic(int Id_Medic);

     Locations AddLocationsInMedic(int idMedico, int idSede);
        //dotnet new page -n Index1-na SaludIntegral.App.Frontend.Pages -o Pages\Medics\
    }
}