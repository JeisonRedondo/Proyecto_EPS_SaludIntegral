using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;


namespace SaludIntegral.App.Frontend.Pages.Medics
{
    public class CreateDoctorAccountModel : PageModel
    {

    // presenta error al crear la entidad   
    /*private readonly ILogger<CreatePatientAccountModel> _logger;
    public CreatePatientAccountModel(ILogger<CreatePatientAccountModel> logger)
    {        _logger = logger;
    }*/
      
        private readonly IRepository_Medic _repoMedic;
        public Medic medic {get;   set;}
        public CreateDoctorAccountModel(IRepository_Medic repoMedic)
        {
            _repoMedic = repoMedic;
        }

        public void OnGet()
        {
            medic = new Medic();            
        }

         public IActionResult OnPost(Medic medic)
        {
            if (ModelState.IsValid)
            {
                _repoMedic.AddMedic(medic);
                return RedirectToPage("IndexM");
            } else
                {
                    return Page();
                }

        }


    }
}
