using System;

namespace SaludIntegral.App.Dominio
{
    public class Schedule
    {
        public int Id{ get; set;}
        public Locations Location { get; set;}
        public Medic Medic { get; set;}
        public DateTime Date { get; set;}
        public string  Note { get; set;}
     }
}