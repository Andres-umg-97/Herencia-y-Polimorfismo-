using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Camion : Vehiculo
    {
        private int carga;
        public Camion(int year, string Color, string Modelo) : base(year, Color, Modelo)
        { carga = 50; }
        public void Cargar (int cuanto)
        { carga += cuanto;
        }
        public int NivelCarga() { return carga; }

        public void Cargar()
        { carga++; }
        public virtual void Descargar(int cuanto)
        {
            if (carga >= cuanto) ;
            carga -= cuanto;
            Console.WriteLine("Se esta bajando la carga");
        }
    }
}
