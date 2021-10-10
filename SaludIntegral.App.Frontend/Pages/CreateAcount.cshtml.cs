using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class CreateAcountModel : PageModel
    {
        private readonly ILogger<CreateAcountModel> _logger;

        public CreateAcountModel(ILogger<CreateAcountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
