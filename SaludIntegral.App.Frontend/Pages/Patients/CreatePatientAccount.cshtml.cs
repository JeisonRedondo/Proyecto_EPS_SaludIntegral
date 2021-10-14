using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;


namespace SaludIntegral.App.Frontend.Pages
{
    public class CreatePatientAccountModel : PageModel
    {

    // presenta error al crear la entidad  
     /*private readonly ILogger<CreatePatientAccountModel> _logger;
    public CreatePatientAccountModel(ILogger<CreatePatientAccountModel> logger)
    {        _logger = logger;    }*/

      
        private readonly IRepository_Patient _repoPatient;
        public Patient Paciente{get;   set;}
        public CreatePatientAccountModel(IRepository_Patient repoPatient)
        {
            _repoPatient = repoPatient;
        }

        public void OnGet()
        {
            Paciente = new Patient();            

        }

         public IActionResult OnPost(Patient Paciente)
        {
            if (ModelState.IsValid)
            {
                _repoPatient.AddPatient(Paciente);
                return RedirectToPage("IndexP");
            } else
                {
                    return Page();
                }

        }


    }
}