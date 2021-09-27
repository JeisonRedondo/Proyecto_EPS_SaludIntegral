using System;

namespace SaludIntegral.App.Dominio
{
    public class Patient:Person
    {
        public int Id_patient { get; set;}
        public bool Contributive { get; set;}
        public bool Particular { get; set;}
        //public EPS EPS { get; set;}
        

    }
}