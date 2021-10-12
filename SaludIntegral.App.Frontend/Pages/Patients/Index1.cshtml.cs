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
    public class Index1Model : PageModel
    {
        private readonly IRepository_Patient _repoPatient;
        public IEnumerable<Patient> pacientes {get;set;}
        public Index1Model(IRepository_Patient repoPatient)
        {
            this._repoPatient= repoPatient;
        }
        public void OnGet()
        {
            pacientes=_repoPatient.GetAllPatients();
        }
    }
}
