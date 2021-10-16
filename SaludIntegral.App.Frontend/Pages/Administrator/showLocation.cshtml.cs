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
    public class showLocationModel : PageModel
    {
        private readonly IRepository_Locations _repoLocation;
        public IEnumerable<Locations> sedes { get; set; }
        public showLocationModel(IRepository_Locations repoLocation)
        {
            _repoLocation = repoLocation;
        }
        public void OnGet()
        {
            sedes = _repoLocation.GetAllLocations();
        }



    }
}
