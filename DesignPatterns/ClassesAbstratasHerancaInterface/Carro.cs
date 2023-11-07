using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ClassesAbstratasHerancaInterface
{
    public abstract class Carro
    {
        public string Modelo { get; set; }

        public int Ano { get; set; }

        public string GetModeloAno()
        {
            return $"Model: {Modelo}\nAno: {Ano}";
        }

        public abstract void SalvarModelo(string modelo);

        public virtual void SalvarAno(int ano)
        {
            this.Ano = ano;
        }
    }
}
