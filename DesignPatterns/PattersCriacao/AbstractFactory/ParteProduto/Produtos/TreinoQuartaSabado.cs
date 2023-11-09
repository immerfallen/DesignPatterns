using DesignPatterns.PattersCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoQuartaSabado : ITreino
    {
        public TreinoQuartaSabado()
        {
            ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino quarta e sábado"); ;
        }
    }
}
