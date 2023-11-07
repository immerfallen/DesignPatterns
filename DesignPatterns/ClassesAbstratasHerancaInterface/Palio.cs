using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ClassesAbstratasHerancaInterface
{
    public class Palio : Carro, ICategoriaY
    {
        public override void SalvarModelo(string modelo)
        {
            this.Modelo = modelo;
        }

        public override void SalvarAno(int ano)
        {

            //qualquer lógica para o Palio
             base.SalvarAno(ano);    
        }

        public void MetodoExclusivoCategoriaY(string categoria)
        {
            Console.WriteLine("ExclusivoCategoriaY"); ;
        }
    }
}
