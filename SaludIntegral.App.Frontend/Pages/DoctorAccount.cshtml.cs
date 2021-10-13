using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class DoctorAccountModel : PageModel
    {
        private readonly ILogger<DoctorAccountModel> _logger;

        public DoctorAccountModel(ILogger<DoctorAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
