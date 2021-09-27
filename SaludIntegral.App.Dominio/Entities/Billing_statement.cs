using System;

namespace SaludIntegral.App.Dominio
{
    public class Billing_statement
    {
        public int Invoice_number { get; set;}
        public float  Value { get; set;}
        public float  Discount { get; set;}
        public float Total { get; set;}

    }
}