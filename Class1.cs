using System.Collections;
using System.Collections.Specialized;

namespace ClassLibrary1
{
    abstract class Persona
    {
        public string nombre;
        public string apellido;
        public string dni;
        public string direccion;
        public string telefono;

        Persona(string nombre, string apellido, string dni, string direccion, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.direccion = direccion;
            this.telefono = telefono;
        }

    }
}
