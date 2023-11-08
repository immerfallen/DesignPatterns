using DesignPatterns.PattersCriacao.FactoryMethod.Enums;
using DesignPatterns.PattersCriacao.FactoryMethod.Interfaces;
using DesignPatterns.PattersCriacao.FactoryMethod.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.FactoryMethod
{
    public class SelecionaService : ServiceFactory
    {
        public override IService FabricarProduto(eTiposServicos tiposServicos)
        {
            switch (tiposServicos)
            {
                case eTiposServicos.tradicional:
                    return new TradicionalService();                    
                case eTiposServicos.premium:
                    return new PremiumService();                    
                case eTiposServicos.master:
                    return new MasterService();                    
                case eTiposServicos.cobertura:
                    return new CoberturaService();                    
                default:
                    return null;
                    
            }
        }
    }
}
