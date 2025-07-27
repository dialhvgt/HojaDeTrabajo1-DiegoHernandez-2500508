using HojaDeTrabajo1_DiegoHernandez_2500508;
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Libro> libros = new List<Libro>();
        int siguienteId = 1;

        void RegistrarLibro(string titulo, string autor)
        {
            foreach (Libro l in libros)
            {
                if (l.ObtenerTitulo() == titulo)
                {
                    Console.WriteLine("Ese libro ya está registrado.");
                    return;
                }
            }

            Libro nuevoLibro = new Libro(titulo, autor, siguienteId);
            libros.Add(nuevoLibro);
            siguienteId++;
            Console.WriteLine("Libro registrado correctamente.");
        }

        void PrestarLibro(string titulo, string usuario)
        {
            foreach (Libro l in libros)
            {
                if (l.ObtenerTitulo() == titulo)
                {
                    if (l.EstaDisponible())
                    {
                        l.Prestar(usuario);
                        Console.WriteLine("Libro prestado a " + usuario);
                    }
                    else
                    {
                        Console.WriteLine("El libro no está disponible.");
                    }
                    return;
                }
            }

            Console.WriteLine("Libro no encontrado.");
        }

        void MostrarLibrosDisponibles()
        {
            Console.WriteLine("\nLibros disponibles:");
            foreach (Libro l in libros)
            {
                if (l.EstaDisponible())
                {
                    l.MostrarInfo();
                }
            }
        }

        RegistrarLibro("El Principito", "Antoine de Saint-Exupéry");
        RegistrarLibro("Cien años de soledad", "Gabriel García Márquez");

        MostrarLibrosDisponibles();

        PrestarLibro("El Principito", "Ana");

        MostrarLibrosDisponibles();
    }
}