using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.Singleton
{
    public class ContextDB
    {
        private static ContextDB _instancia = null;
        private ContextDB()
        {
        }

        public static ContextDB Instacia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new ContextDB();
                    Console.WriteLine("Instância context DB criada.");
                }
                return _instancia;
            }
        }

        public void ExecutaQuery(string query)
        {
            Console.WriteLine(query);
        }
    }
}
