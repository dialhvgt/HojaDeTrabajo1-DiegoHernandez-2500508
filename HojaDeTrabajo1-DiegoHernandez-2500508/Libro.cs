using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaDeTrabajo1_DiegoHernandez_2500508
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private bool disponible;
        private int id;
        private string usuarioPrestamo;

        public Libro(string titulo, string autor, int id)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.id = id;
            this.disponible = true;
            this.usuarioPrestamo = "";
        }
        public string ObtenerTitulo()
        {
            return titulo;
        }

        public bool EstaDisponible()
        {
            return disponible;
        }

        public void Prestar(string usuario)
        {
            disponible = false;
            usuarioPrestamo = usuario;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("ID: " + id + " | Título: " + titulo + " | Autor: " + autor + " | Disponible: " + disponible);
        }
    }
}

