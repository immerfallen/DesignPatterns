using DesignPatterns.PattersCriacao.AbstractFactory.ParteProduto.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.AbstractFactory.ParteProduto.Produtos
{
    public class TreinoTercaSexta : ITreino
    {
        public TreinoTercaSexta()
        {
            ObterTreino();
        }
        public void ObterTreino()
        {
            Console.WriteLine("Treino terça e sexta");
        }
    }
}
