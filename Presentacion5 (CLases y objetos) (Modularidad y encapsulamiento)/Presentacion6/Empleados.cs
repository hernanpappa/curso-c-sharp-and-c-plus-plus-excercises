﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion6
{
    class Empleados
    {
        public Empleados()          //Esto es un metodo constructor donde se inicializan las variables
        {
            Nombre = "";
            SueldoDiario = 0.0m;
            Edad = 0;
        }

        private string _Nombre;

        public string Nombre
        {
            get => _Nombre;
            set => _Nombre = value;
        }

        public decimal SueldoDiario { get; set; }

        public int Edad { get; set; }
        

        

        public decimal CalculaSalario(int NumeroDias)
        {
            return SueldoDiario * NumeroDias;
        }



    }
}
