using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class CreateAccountModel : PageModel
    {
        private readonly ILogger<CreateAccountModel> _logger;

        public CreateAccountModel(ILogger<CreateAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
