using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class LogginModel : PageModel
    {
        private readonly ILogger<LogginModel> _logger;

        public LogginModel(ILogger<LogginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
