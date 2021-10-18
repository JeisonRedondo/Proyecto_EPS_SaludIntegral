using System;
using System.ComponentModel.DataAnnotations;

namespace SaludIntegral.App.Dominio
{
    /// <summary>
    /// Medic.
    /// </summary>
    /// <seealso cref="Person" />
    public class Medic : Person
    {
        [Required(ErrorMessage="Campo Obligatorio")]
        public string Specialization { get; set; }


    }
}
