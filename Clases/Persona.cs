using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Clases
{
    public abstract class Persona
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Dni { get; set; }
        public Persona(string firstName, string lastName, int age, int dni)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Dni = dni;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
