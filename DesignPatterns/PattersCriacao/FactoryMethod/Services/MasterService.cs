using DesignPatterns.PattersCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.FactoryMethod.Services
{
    public class MasterService : IService
    {
        public MasterService()
        {
            Console.WriteLine("Produto master criado com sucesso");
        }
        public void ExecutaCobrancaServico()
        {
            //Lógica para Master
        }
    }
}
