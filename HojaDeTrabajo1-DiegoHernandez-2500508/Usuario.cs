using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HojaDeTrabajo1_DiegoHernandez_2500508
{
    internal class Usuario
    {
        // Atributos privados
        private string dpi;
        private string contraseña;

        // Propiedad pública para el nombre (sin validación)
        public string Nombre { get; set; }

        // Propiedad para el DPI (con validación de exactamente 13 dígitos)
        public string DPI
        {
            get { return dpi; }
            set
            {
                if (value.Length == 13 && EsNumero(value))
                {
                    dpi = value;
                }
                else
                {
                    Console.WriteLine("DPI inválido. Debe tener exactamente 13 dígitos.");
                }
            }
        }

        // Propiedad para la contraseña (solo se puede asignar, no leer)
        public string Contraseña
        {
            set
            {
                if (value.Length >= 6)
                {
                    contraseña = value;
                }
                else
                {
                    Console.WriteLine("La contraseña debe tener al menos 6 caracteres.");
                }
            }
        }

        // Constructor
        public Usuario(string nombre, string dpi, string contraseña)
        {
            Nombre = nombre;
            DPI = dpi;             // usa la propiedad que ya valida
            Contraseña = contraseña; // usa la propiedad que ya valida
        }

        // Método para autenticar al usuario comparando contraseñas
        public bool Autenticar(string input)
        {
            return contraseña == input;
        }

        // Función auxiliar para validar que un string tenga solo números
        private bool EsNumero(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
