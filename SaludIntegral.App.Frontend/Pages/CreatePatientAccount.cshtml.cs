using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class CreatePatientAccountModel : PageModel
    {
        private readonly ILogger<CreatePatientAccountModel> _logger;

        public CreatePatientAccountModel(ILogger<CreatePatientAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
