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
    public class LoginModel : PageModel
    {
        private readonly IRepository_Patient _repoPatient;
        
        public Patient paciente { get; set; }
        
        public string EmailE { get; set; }

        public string PasswordE { get; set; }
        public LoginModel(IRepository_Patient repoPatient)
        {
            _repoPatient = repoPatient;
        }
        
        public IActionResult OnPost( string EmailE, string PasswordE)
        {
            
            if (String.IsNullOrEmpty(EmailE) & String.IsNullOrEmpty(PasswordE))
            {
                EmailE = "";
                PasswordE ="";
                return RedirectToPage("/Login");
                // pacientes = _repoPatient.GetAllPatients();
            }
            else
            {
                 paciente =_repoPatient.SearchPatiensbyEmail2(EmailE);
                
                if (paciente.Password==PasswordE)
                {
                     //return RedirectToPage("/IndexP");
                     return RedirectToPage("/Administrator/IndexA");
                } else
                {
                    return RedirectToPage("/Login");
                }

               /*  foreach (var p in pacientes)
                {
                    if (p.Email==EmailE & p.Password==PasswordE)
                    {
                       return Pages();
                    }else
                    {
                        return RedirectToPage("IndexP");
                    }
                } */
            }
        }
        
    }
}
