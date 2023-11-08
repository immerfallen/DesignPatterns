using DesignPatterns.PattersCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.FactoryMethod.Services
{
    public class PremiumService : IService
    {
        public PremiumService()
        {
            Console.WriteLine("Produto premium criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
           // Lógica premium
        }
    }
}
