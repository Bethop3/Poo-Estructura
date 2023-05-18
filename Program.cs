using Poo_Estructura.Servicios;
using System;

namespace Poo_Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AlumnoServicio alumnoServicio = new AlumnoServicio();
            var res = alumnoServicio.Agregar();
            alumnoServicio.Imprimir(res);
        }
    }
}
