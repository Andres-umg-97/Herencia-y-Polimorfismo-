using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class AutoDeCombustion : Vehiculo
    {
        private int LlenarTanque;
        
        public AutoDeCombustion(int year, string Color, string Modelo) : base(year, Color, Modelo)
        {
            LlenarTanque = 50;
        }
        public void CargarGasolina(int cuanto)
        {    
            LlenarTanque += cuanto;
        }

        public int NivelGasolina() { return LlenarTanque; }
        
        public void CargarGasolina()
        { LlenarTanque++; }
    }
}
