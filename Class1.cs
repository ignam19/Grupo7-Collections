using System.Xml;

namespace ClassLibrary1
{
    public class Alumno //: Persona//
    {
        string Materia;
        int Curso;
        double nota;
        //List<notas>

        public Alumno(string materia, int curso, double nota)
        {
            Materia = materia;
            Curso = curso;
            this.nota = nota;
        }

        public double calcularPromedio() 
        {
            return nota;
        }

        public void enviarTarea() 
        {
        
        }

        public void registarAsistencia() 
        {

        }
    }
}
