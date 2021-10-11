﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SaludIntegral.App.Frontend.Pages
{
    public class CreateDoctorAccountModel : PageModel
    {
        private readonly ILogger<CreateDoctorAccountModel> _logger;

        public CreateDoctorAccountModel(ILogger<CreateDoctorAccountModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
