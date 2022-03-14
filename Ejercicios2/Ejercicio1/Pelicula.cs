using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2.Ejercicio1
{
    internal class Pelicula

    {
        private string _titulo;
        private string _genero;
        private Director _director;
        private int _anioPublicacion;
        private string _formato;

        public string formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

        public int anioPublicacion
        {
            get { return _anioPublicacion; }
            set { _anioPublicacion = value; }
        }

        public Director director
        {
            get { return _director; }
            set { _director = value; }
        }

        public string titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Pelicula(string titulo, string genero, Director director, int anioPublicacion, string formato)
        {
            _titulo = titulo;
            _genero = genero;
            _director = director;
            _anioPublicacion = anioPublicacion;
            _formato = formato;
        }
        public override string ToString()
        {
            return $"Titulo:{titulo}, Genero: {genero}, Director: {director}, Año publicacion: {anioPublicacion}, Formato:{formato}";
        }
    }
}
