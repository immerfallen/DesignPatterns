using DesignPatterns.PattersCriacao.AbstractFactory.ParteCriacao.Interfaces;
using DesignPatterns.PattersCriacao.AbstractFactory.ParteProduto.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.AbstractFactory.ParteCriacao.Factories
{
    public class TercaSextaFactory : IFactory
    {
        public TercaSextaFactory()
        {
            ObterRotinaDiaria();
        }
        public void ObterRotinaDiaria()
        {
            Console.WriteLine("Obtida rotina de segunda e quinta");
            DietaTercaSexta dieta = new DietaTercaSexta();
            TreinoTercaSexta treino = new TreinoTercaSexta();

            dieta.ObterAlimentacao();
            treino.ObterTreino();
        }
    }
}
