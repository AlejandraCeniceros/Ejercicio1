using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public bool Moverse { get; set; }
        public bool Disparar { get; set; }
        public bool Explotar { get; set; }
        public int Posicionx { get; set; }
        public int Posiciony { get; set; }

        private string _ganas;
        public string Ganas
        {
            get
            {
                return _ganas;
            }
            set
            {
                if (value.Length >= 100)
                {
                    _ganas = value;
                }
                else
                {
                    throw new Exception("El puntaje no puede ser menor a 100");
                }
            }
        }
    }
}
