using System;
using System.ComponentModel.DataAnnotations;

namespace SaludIntegral.App.Dominio
{
    /// <summary>
    /// Schedule.
    /// </summary>
    public class Schedule
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Sede para la Cita")]
        public Locations Location { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Medico que Atendera la cita.")]
        public Medic Medic { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Paciente que Requiere la Cita.")]

        public Patient Patient { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [Display(Name = "Dia que se desea la cita.")]

        public DateTime Date { get; set; }
        [Display(Name = "Nota Del Medico.")]
        public string Note { get; set; }
        [Display(Name = "Estado de la Cita.")]
        public string Date_Status { get; set; }
    }
}