using System;

namespace SaludIntegral.App.Dominio
{
    public class Person
    {
        public int Id { get; set;}
        public string Identification { get; set;}
        public string Names { get; set;}
        public DateTime DateOfBirth { get; set;}
        public string Gender { get; set;}
        public string Phone_number { get; set;}
        public string Email { get; set;}
        public string Password { get; set;}
        public Locations Location { get; set;}

    }
}
