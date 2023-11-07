using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Propriedades
    {
        private double _segundos;

        public double Horas
        {
            set
            {
                if(value < 0 || value > 24)
                {
                    Console.WriteLine("Valor inválido...");
                }
                else
                {
                    _segundos = value*3600;
                }
            }
            get
            {
                return _segundos / 3600;
            }
        }
    }
}
