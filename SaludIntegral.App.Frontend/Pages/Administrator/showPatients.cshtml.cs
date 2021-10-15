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
    public class showPatientsModel : PageModel
    {        
        private readonly IRepository_Patient _repoPatient;
        public IEnumerable<Patient> patients {get; set;}
        public showPatientsModel( IRepository_Patient repoPatient)
        {
            _repoPatient=repoPatient;
        }
        public void OnGet()
        {
            patients = _repoPatient.GetAllPatients();
        }






    }
}
