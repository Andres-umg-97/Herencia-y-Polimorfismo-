using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Motocicleta : Vehiculo
    {
        private int Cadena;
        private int velocidad;
        public Motocicleta(int year, string Color, string Modelo) : base(year, Color, Modelo)
        {
            Cadena = 0;
        }
        public void CambiarCadena(int cuanto)
        {
            if (cuanto >= 0)
            {
                Cadena = cuanto;
            }
            else
            {
                Console.WriteLine("La cadena no se esta desgastando.");
            }
        }
        public virtual void Acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora", velocidad);
        }
        public virtual void Frenar(int decremento)
        {
            velocidad -= decremento;
            Console.WriteLine("la velocidad esta disminuyendo a {0} KMS / Hora", velocidad);
        }

        }
}

