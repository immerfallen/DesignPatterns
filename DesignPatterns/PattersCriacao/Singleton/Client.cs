using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.PattersCriacao.Singleton
{
    public class Client
    {
        public void ConsumirDB()
        {
            var instancia = ContextDB.Instacia;
            instancia.ExecutaQuery("Select * from loucura");

            instancia = ContextDB.Instacia;
            instancia.ExecutaQuery("Delete * from loucura");

            instancia = ContextDB.Instacia;
            instancia.ExecutaQuery("Updtae ....");
        }
    }
}
