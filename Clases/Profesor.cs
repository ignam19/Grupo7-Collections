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
        public List<string> Materias { get; set; }
        public int HorasCatedra { get; set; }

        public Profesor(int sueldo, List<string> materias, int horasCatedra, string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            Sueldo = sueldo;
            Materias = materias;
            HorasCatedra = horasCatedra;
        }
    }
}
