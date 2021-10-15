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
    public class seeMyAccountMModel : PageModel
    {
        private readonly IRepository_Medic _repoMedic;
        public IEnumerable<Medic> medicos { get; set; }
        public int gActual { get; set; }
        public string bActual { get; set; }
        public seeMyAccountMModel(IRepository_Medic repoMedic)
        {
            _repoMedic = repoMedic;
        }
        public void OnGet(int? g, string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                medicos = _repoMedic.GetAllMedics();
            }
            else
            {
                bActual = b;
                medicos = _repoMedic.SearchMedics(b);
            }
        }
    }
}
