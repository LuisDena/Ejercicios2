using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2.Ejercicio1
{
    internal class Director
    {
        private string _nombre;
        private int _edad;

        public int edad
        {
            get { return _edad; }
            set { _edad = value; }
        }


        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Director(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public override string ToString()
        {
            return $"Nombre del director: {nombre}, Edad: {edad}";
        }
    }
}
