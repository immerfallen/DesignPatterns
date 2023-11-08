using DesignPatterns.PattersCriacao.FactoryMethod;
using DesignPatterns.PattersCriacao.FactoryMethod.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao
{
    public class Client
    {
        public void ExecutarCriacaoProduto()
        {
            var client = new SelecionaService();

            var continuar = true;
            while (continuar)
            {
                Console.WriteLine("Selecione o tipo de serviço\n");
                Console.WriteLine("0 - Tradicional\n");
                Console.WriteLine("1 - Premium\n");
                Console.WriteLine("2 - Master\n");
                Console.WriteLine("3 - Cobertura\n");

                Console.Write("Digite o número do serviço que deseja selecionar:");
                int tipoServico = Convert.ToInt32(Console.ReadLine());                

                var servicoProduto = client.FabricarProduto((eTiposServicos)tipoServico);

                Console.WriteLine("Deseja calcular outro serviço? (1 - Sim), (2-Não)");

                int resp = Convert.ToInt32(Console.ReadLine());

                continuar = resp == 1;
            }
        }
    }
}
