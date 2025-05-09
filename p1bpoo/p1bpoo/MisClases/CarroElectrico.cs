﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int year, string Color, string Modelo) : base (year, Color, Modelo)
        {
            cargaBateria = 50;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            cargaBateria--;
        }
        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }

    }
}
