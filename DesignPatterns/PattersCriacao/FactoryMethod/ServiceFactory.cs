using DesignPatterns.PattersCriacao.FactoryMethod.Enums;
using DesignPatterns.PattersCriacao.FactoryMethod.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.FactoryMethod
{
    public abstract class ServiceFactory
    {
        public abstract IService FabricarProduto(eTiposServicos tiposServicos);
    }
}
