using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2.Ejercicio1
{
    internal class Estante
    {
        private int _numeroEstante;
        private List<Pelicula> _peliculas;

        public List<Pelicula> peliculas
        {
            get { return _peliculas; }
            set { _peliculas = value; }
        }

        public int numeroEstante
        {
            get { return _numeroEstante; }
            set { _numeroEstante = value; }
        }

        public Estante(int numeroEstante, List<Pelicula> peliculas)
        {
            _numeroEstante = numeroEstante;
            this._peliculas = new List<Pelicula>();
        }
    }
}
