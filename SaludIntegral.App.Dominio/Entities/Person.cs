using System;
using System.ComponentModel.DataAnnotations;

namespace SaludIntegral.App.Dominio
{
    /// <summary>
    /// Person.
    /// </summary>
    public class Person
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50,ErrorMessage="Longitud Maxima 50")]
        public string Identification { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50,ErrorMessage="Longitud Maxima 50")]
        public string Names { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        public DateTime DateOfBirth { get; set; }
        [StringLength(50,ErrorMessage="Longitud Maxima 50")]
        public string Gender { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(20,ErrorMessage="Longitud Maxima 20")]
        public string Phone_number { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        public string Email { get; set; }
        [Required(ErrorMessage="Campo Obligatorio")]
        [StringLength(50,ErrorMessage="Longitud Maxima 50")]
        public string Password { get; set; }
        
        [Display(Name="Ciudad de Residencia.")]
        
        public Locations Location { get; set; }

    }
}
