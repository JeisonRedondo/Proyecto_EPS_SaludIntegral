using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SaludIntegral.App.Frontend.Pages
{
    public class UpDateDoctorAccountModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class UpDateDoctorAccountModel : PageModel
    {
        private readonly ILogger<UpDateDoctorAccountModel> _logger;

        public UpDateDoctorAccountModel(ILogger<UpDateDoctorAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}*/