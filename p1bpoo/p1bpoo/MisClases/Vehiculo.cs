using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Vehiculo
    {
        public string Color { get; set; }
        public string Modelo { get;  }
        public int Year { get;  }

        private int velocidad = 0;



        public Vehiculo(int Year, string Color, string Modelo)
        {
            this.Color = Color;
            this.Modelo = Modelo;
            this.Year = Year;
        }

        public void InformacionVehiculo()
        {
            Console.WriteLine("Color {0}:", this.Color);
            Console.WriteLine("Modelo {0}:", this.Modelo);
            Console.WriteLine("Año {0}", this.Year);
        }
        public virtual void acelerar(int cuanto)
        {
            velocidad += cuanto;
            Console.WriteLine("vas a {0} KMS / Hora",velocidad);
        }
        public virtual void frenar(int decremento)
        { velocidad -= decremento;
            Console.WriteLine("la velocidad esta disminuyendo a {0} KMS / Hora", velocidad);
        }
    }
}
