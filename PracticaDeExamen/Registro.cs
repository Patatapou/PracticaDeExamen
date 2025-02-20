using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDeExamen
{
    internal class Registro
    {
        // Atributos privados
        private string nombre;
        private string edad;
        private string estado;

        // Constructor
        public Registro()
        {
            this.nombre = "";
            this.edad = "";
            this.estado = "";
        }
        public Registro(string nombre, string edad, string estado)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.estado = estado;
        }

        // Métodos Get y Set
        public string GetNombre() => nombre;
        public void SetNombre(string nombre) => this.nombre = nombre;

        public string GetEdad() => edad;
        public void SetEdad(string edad) => this.edad = edad;

        public string GetEstado() => estado;
        public void SetEstado(string estado) => this.estado = estado;

        // Sobrecarga del método ToString()
        public override string ToString()
        {
            return "Nombre: " + nombre + "\nEdad: " + edad + "\nEstado: " + estado;
        }
    }
}
