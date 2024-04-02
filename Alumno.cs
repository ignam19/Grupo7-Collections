using System.Xml;

namespace ClassLibrary1
{
    public class Alumno : Persona
    {
        public string Materia { get; set; }
        public int Curso { get; set; }
        public double Nota { get; set; }

        public Alumno(string materia, int curso, double nota, string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            Materia = materia;
            Curso = curso;
            Nota = nota;
        }

        public double calcularPromedio() 
        {
            return Nota;
        }

        public void enviarTarea() 
        {
        
        }

        public void registarAsistencia() 
        {

        }
    }
}
