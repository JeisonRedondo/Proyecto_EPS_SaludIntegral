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
    public class scheduleAppointmentModel : PageModel
    {
        private readonly IRepository_Schedule _repoDate;

        private readonly IRepository_Patient _repoPatient;
        private readonly IRepository_Medic _repoMedic;
        public Patient patient { get; set; }
        public IEnumerable<Medic> medicos {get; set;}
        public scheduleAppointmentModel(IRepository_Patient repoPatient,IRepository_Schedule repoDate,IRepository_Medic repoMedic)
        {
            _repoPatient = repoPatient;
            _repoDate = repoDate;
            _repoMedic = repoMedic;
        }




        public IActionResult OnGet(int id)
        {
            patient = _repoPatient.GetPatient(id);
            if (patient == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }


        }

        public void OnGet()
        {
            medicos = _repoMedic.GetAllMedics();
        }



    }

}
