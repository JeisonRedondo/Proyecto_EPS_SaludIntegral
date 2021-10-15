using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SaludIntegral.App.Dominio;
using SaludIntegral.App.Persistencia;

namespace SaludIntegral.App.Frontend.Pages.Administrator
{
    public class createLocationModel : PageModel
    {
        private readonly IRepository_Locations _repoLocation;
        public Locations location { get; set; }
        public createLocationModel(IRepository_Locations repoLocation)
        {
            _repoLocation = repoLocation;
        }
        public void OnGet()
        {
            location = new Locations();
        }

        public IActionResult OnPost(Locations location)
        {
            if (ModelState.IsValid)
            {
                _repoLocation.AddLocations(location);
                return RedirectToPage("IndexA");
            }
            else
            {
                return Page();
            }

        }



    }
}
