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
    public class UpDateDoctorAccountModel : PageModel
    {
       private readonly IRepository_Medic _repoMedic;
        public Medic medic {get; set;}
        public UpDateDoctorAccountModel(IRepository_Medic repoMedic)
        {
            _repoMedic= repoMedic;
        }
        public IActionResult OnGet(int id)
        {
            medic=_repoMedic.GetMedic(id);
            if (medic == null)
            {
                return NotFound();
            } else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Medic medic)
            {
               _repoMedic.UpdateMedic(medic);
               //una vez termina el update retorna la pagina
               return RedirectToPage("IndexM"); 
            }
    }
}
