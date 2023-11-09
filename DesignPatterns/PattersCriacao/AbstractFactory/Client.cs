using DesignPatterns.PattersCriacao.AbstractFactory.ParteCriacao.Factories;
using DesignPatterns.PattersCriacao.AbstractFactory.ParteCriacao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.AbstractFactory
{
    public class Client
    {
        public void ConsultarRotinaAluno()
        {
            while (true)
            {
                var continuar = true;
                while (continuar)
                {
                    IFactory factory = null;

                    Console.WriteLine("Selecione a rotina\n");
                    Console.WriteLine("1 - Segunda e quinta\n");
                    Console.WriteLine("2 - Terça e Sexta\n");
                    Console.WriteLine("3 - Quarta e Sábado\n");

                    Console.Write("Selecione a rotina desejada:");
                    int rotina = Convert.ToInt32(Console.ReadLine());

                    switch (rotina)
                    {
                        case 1:
                            factory = new SegundaQuintaFactory();
                            break;
                        case 2:
                            factory = new TercaSextaFactory();
                            break;
                        case 3:
                            factory = new QuartaSabadoFactory();
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine("Deseja escolher outra rotina? (1 - Sim), (2-Não)");

                    int resp = Convert.ToInt32(Console.ReadLine());

                    continuar = resp == 1;
                }
            }
        }
    }
}
