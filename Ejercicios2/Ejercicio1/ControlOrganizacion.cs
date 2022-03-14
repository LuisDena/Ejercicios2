using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios2.Ejercicio1
{
    internal class ControlOrganizacion
    {
        private List<Pelicula> _peliculas;

        public List<Pelicula> peliculas
        {
            get { return _peliculas; }
            set { _peliculas = value; }
        }

        public ControlOrganizacion()
        {
            _peliculas = new List<Pelicula>();
        }
        public void showMenuPrincipal() {
            int opcionSeleccionada = 0;
            Console.Clear();
            do
            {
                Console.WriteLine("Bienvenido al sistema de organizacion de peliculas");
                Console.WriteLine("1.- Peliculas");
                Console.WriteLine("2.- Organizar Alfabeticamente");
                Console.WriteLine("3.- Organizar por Genero");
                Console.WriteLine("4.- Organizar por año de publicacion");
                Console.WriteLine("5.- Salir");
            } while (!validaMenu(5, ref opcionSeleccionada));
            switch (opcionSeleccionada)
            {
                case 1:
                    crudPeliculas();
                    break;
                case 2:
                    organizarAlfabeticamente();
                    break;
                case 3:
                    organizarPorGenero();
                    break;
                case 4:
                    organizarPorAnioPublicacion();
                    break;
                case 5:
                    break;
            }
        }

        private void organizarPorAnioPublicacion()
        {
            this._peliculas = _peliculas.OrderBy(p =>p.anioPublicacion).ToList();
            listarPeliculas();
            Console.WriteLine("Presiona 'Enter' Para continuar...");
            Console.ReadLine();
            showMenuPrincipal();
        }

        private void organizarPorGenero()
        {
            this._peliculas = _peliculas.OrderBy(p => p.genero).ToList();
            listarPeliculas();
            Console.WriteLine("Presiona 'Enter' Para continuar...");
            Console.ReadLine();
            showMenuPrincipal();
        }

        private void organizarAlfabeticamente()
        {
            this._peliculas = _peliculas.OrderBy(p => p.titulo).ToList();
            listarPeliculas();
            Console.WriteLine("Presiona 'Enter' Para continuar...");
            Console.ReadLine();
            showMenuPrincipal();
        }

        public bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opcion Invalida.");
                    return false;
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es valido, debes ingresar un numero.");
                return false;
            }
        }
        public void crudPeliculas() {
            int opcionSeleccionada = 0;
            Console.Clear();
            do {
                Console.WriteLine("Peliculas");
                Console.WriteLine("1.- Listar");
                Console.WriteLine("2.- Agregar");
                Console.WriteLine("3.- Editar");
                Console.WriteLine("4.- Eliminar");
                Console.WriteLine("5.- Regresar");
            }while (!validaMenu(5, ref opcionSeleccionada));
            Console.Clear();
            switch (opcionSeleccionada) { 
                case 1:
                    listarPeliculas();
                    Console.WriteLine("Presiona 'Enter' Para continuar...");
                    Console.ReadLine();
                    crudPeliculas();
                    break;
                case 2:
                    agregarPelicula();
                    break;
                case 3:
                    listarPeliculas();
                    editarPelicula();
                    break;
                case 4:
                    eliminarPelicula();
                    break;
                case 5:
                    showMenuPrincipal();
                    break;
            }
        }

        private void agregarPelicula()
        {
            string? nombre;
            string? genero;
            Director? director;
            int anioPublicacion;
            string? formato;

            Console.WriteLine("Agregar Pelicula");
            do
            {
                Console.Write("Nombre: ");
                nombre = Console.ReadLine();
                if (nombre == null || nombre == "")
                {
                    Console.Write("Nombre invalido");
                }
            } while (nombre == null || nombre== "");
            do
            {
                Console.Write("Genero: ");
                genero = Console.ReadLine();
                if (genero == null || genero == "")
                {
                    Console.Write("Genero invalido");
                }
            } while (genero == null || genero == "");
            do
            {
                Console.Write("Director: ");
                Console.WriteLine("Nombre del director: ");
                string? nombreDirector=Console.ReadLine();
                Console.WriteLine("Edad del director");
                int edadDirector = Int32.Parse(Console.ReadLine());
                director = new Director(nombreDirector,edadDirector);
                if (director == null )
                {
                    Console.Write("Director invalido");
                }
            } while (director == null);
            do
            {
                Console.Write("Año publicacion: ");
                anioPublicacion = Int32.Parse(Console.ReadLine());
                if (anioPublicacion == null || anioPublicacion == 0)
                {
                    Console.Write("Año invalido");
                }
            } while (anioPublicacion == null || anioPublicacion == 0);
            do
            {
                Console.Write("Formato: ");
                formato = Console.ReadLine();
                if (formato == null || formato== "")
                {
                    Console.Write("Formato invalido");
                }
            } while (formato == null || formato== "");

            Pelicula nuevaPelicula = new Pelicula(nombre, genero,director,anioPublicacion,formato);
            _peliculas.Add(nuevaPelicula);
            Console.WriteLine("Pelicula agregada correctamente, presiona enter para continuar");
            Console.ReadLine();
            crudPeliculas();
        }

        private void listarPeliculas()
        {
            Console.WriteLine("Lista de Peliculas");
            foreach (Pelicula item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }

        }

        private void editarPelicula() {
            string? nombre;
            string? genero;
            listarPeliculas();
            do
            {
                Console.Write("Escribe el titulo de la pelicula a editar: ");
                nombre = Console.ReadLine();
                if (nombre == null || nombre== "")
                {
                    Console.Write("titulo invalido");
                }
            } while (nombre == null || nombre== "");
            Pelicula? peliculaEdicion= _peliculas.FirstOrDefault(u => u.titulo == nombre);
            if (peliculaEdicion == null)
            {
                Console.WriteLine("No se encontro la pelicula, Presiona enter para continuar...");
                Console.ReadLine();
                crudPeliculas();
            }
            else
            {
                nombre = null;
                do
                {
                    Console.Write("Genero: ");
                    genero = Console.ReadLine();
                    if (genero == null || genero == "")
                    {
                        Console.Write("Genero invalido");
                    }
                } while (genero == null || genero== "");
                peliculaEdicion.genero= genero;
                Console.WriteLine($"La pelicula con titulo: {peliculaEdicion.titulo} se edito con exito. Presione enter para continuar ");
                Console.ReadLine();
                crudPeliculas();
            }
        }

        private void eliminarPelicula() {
            string? nombre = null;
            listarPeliculas();
            do
            {
                Console.Write("Escribe el Titulo de la pelicula a eliminar: ");
                nombre = Console.ReadLine();
                if (nombre == null || nombre== "")
                {
                    Console.Write("Titulo invalido");
                }
            } while (nombre == null || nombre== "");
            Pelicula? peliculaEliminar= _peliculas.FirstOrDefault(u => u.titulo== nombre);
            if (peliculaEliminar == null)
            {
                Console.WriteLine("No se encontro la Pelicula, Presiona enter para continuar...");
                Console.ReadLine();
                crudPeliculas();
            }
            else
            {
                _peliculas.Remove(peliculaEliminar);
                Console.WriteLine($"La pelicula con titulo: {peliculaEliminar.titulo} se elimino con exito. Presione enter para continuar ");
                Console.ReadLine();
                crudPeliculas();
            }
        }
    }
}

