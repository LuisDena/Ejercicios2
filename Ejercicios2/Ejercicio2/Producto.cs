using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//María acaba de emprender en su propio negocio, una tienda de productos para el hogar y otras
//Categorías variadas y le ha ido muy bien.
//
//Le gustaría expandir su negocio, pero no está muy segura
//de que nuevos productos debería agregar a su tienda,
//tiene un Excel con toda la información de sus ventas,
//pero no sabe como aprovechar esa información.
//Le gustaría conocer que productos se
//venden más o que categorías son las más populares en su tienda además de ya no utilizar Excel
//para registrar sus ventas.

namespace Ejercicios2.Ejercicio2
{
    internal class Producto
    {
        private string _nombre;
        private int _precio;

        public int precio
        {
            get { return _precio; }
            set { _precio = value; }
        }


        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

    }
}
