using System.Xml;

namespace ClassLibrary1.Clases
{
    public class Alumno : Persona
    {
        public string Materia { get; set; }
        public int Curso { get; set; }
        public double Nota { get; set; }

        public List<string> Materias { get; set; }

        public Alumno(string materia, int curso, double nota, string firstName, string lastName, int age, List<string> materias)
            : base(firstName, lastName, age)
        {
            Materia = materia;
            Curso = curso;
            Nota = nota;
            Materias = materias;
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
