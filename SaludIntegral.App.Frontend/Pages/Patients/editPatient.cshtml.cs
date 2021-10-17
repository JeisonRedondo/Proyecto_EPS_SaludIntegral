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
    public class editPatientModel : PageModel
    {
        private readonly IRepository_Patient _repoPatient;
        public Patient patient { get; set; }
        public editPatientModel(IRepository_Patient repoPatient)
        {
            _repoPatient = repoPatient;
        }
        public IActionResult OnGet(int id)
        {
            patient = _repoPatient.GetPatient(id);
            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Patient patient)
        {
            _repoPatient.UpdatePatient(patient);
            return RedirectToPage("IndexP");
        }



    }
}