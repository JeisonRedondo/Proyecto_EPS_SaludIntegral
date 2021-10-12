using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia; 

namespace SaludIntegral.App.Frontend.Pages.Medics
{
    public class Index1Model : PageModel
    {
        private readonly IRepository_Medic _repoMedico;
        public IEnumerable<Medic> medicos {get; set;}
        public Index1Model(IRepository_Medic repoMedico)
        {
            _repoMedico=repoMedico;
        }
        public void OnGet()
        {
            medicos = _repoMedico.GetAllMedics();
        }
    }
}
