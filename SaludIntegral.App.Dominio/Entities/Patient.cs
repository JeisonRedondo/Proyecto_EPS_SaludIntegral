using System;
using System.ComponentModel.DataAnnotations;

namespace SaludIntegral.App.Dominio

{
    /// <summary>
    /// Patient.
    /// </summary>
    /// <seealso cref="Person" />
    public class Patient : Person
    {
        [StringLength(50, ErrorMessage = "Longitud Maxima 50")]
        public string EPS { get; set; }



    }
}