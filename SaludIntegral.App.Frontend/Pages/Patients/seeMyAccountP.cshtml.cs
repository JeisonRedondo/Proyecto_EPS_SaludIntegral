using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Frontend.Pages.Patients
{
    public class seeMyAccountPModel : PageModel
    {
        private readonly IRepository_Patient _repoPatient;
        public IEnumerable<Patient> pacientes { get; set; }
        public int gActual { get; set; }
        public string bActual { get; set; }
        public seeMyAccountPModel(IRepository_Patient repoPatient)
        {
            _repoPatient = repoPatient;
        }
        public void OnGet(int? g, string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = null;
                pacientes = _repoPatient.SearchPatiens(bActual);

                // pacientes = _repoPatient.GetAllPatients();
            }
            else
            {
                bActual = b;
                pacientes = _repoPatient.SearchPatiens(b);
            }
        }
    }
}
