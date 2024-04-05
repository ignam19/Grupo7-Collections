using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Clases
{
    public class Profesor : Persona
    {
        public int Sueldo {  get; set; }
        public int HorasCatedra { get; set; }

        public Profesor(int sueldo, int horasCatedra, string firstName, string lastName, int age, int dni)
            : base(firstName, lastName, age, dni)
        {
            Sueldo = sueldo;
            HorasCatedra = horasCatedra;
        }
    }
}
