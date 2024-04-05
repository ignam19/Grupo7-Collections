using System.Xml;

namespace ClassLibrary1.Clases
{
    public class Alumno : Persona
    {
        public double promedio {  get; set; }
        public Alumno(double promedio, string firstName, string lastName, int age, int dni)
            : base(firstName, lastName, age, dni)
        {
           
        }
    }
}
