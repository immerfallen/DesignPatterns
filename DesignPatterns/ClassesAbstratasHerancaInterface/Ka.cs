using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ClassesAbstratasHerancaInterface
{
    public class Ka : Carro, ICategoriaX
    {
        public override void SalvarModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public override void SalvarAno(int ano)
        {
            //Lógica para o Ka
            base.SalvarAno(ano);
        }

        public void MetodoExclusivoCategoriaX()
        {
            Console.WriteLine("ExclusivoCategoriaX"); ;
        }
    }
}
