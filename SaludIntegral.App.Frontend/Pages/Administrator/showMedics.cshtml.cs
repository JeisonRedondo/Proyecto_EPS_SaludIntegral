using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Frontend.Pages
{
    public class showMedicsModel : PageModel
    {           
    
        private readonly IRepository_Medic _repoMedic;
        public IEnumerable<Medic> medicos {get; set;}
        public showMedicsModel( IRepository_Medic repoMedic)
        {
            _repoMedic=repoMedic;
        }
        public void OnGet()
        {
            medicos = _repoMedic.GetAllMedics();
        }
    
    }
}
