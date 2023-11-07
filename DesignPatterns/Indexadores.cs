using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Indexadores
    {
        private List<Indexadores> _indexadores = new List<Indexadores>();
        public string Mensagem { get; set; }

        public Indexadores(string mensagem = "")
        {
            if (!string.IsNullOrEmpty(mensagem))
            {
                Mensagem = mensagem;
            }
        }

        public Indexadores this[int index]
        {
            get
            {
                return _indexadores[index];
            }
            set
            {
                _indexadores.Add(value);
            }
        }

    }
}

