﻿/*using DesignPatterns.PattersCriacao; */
/*using DesignPatterns.PattersCriacao.AbstractFactory;*/
using DesignPatterns.PattersCriacao.Singleton;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Indexadores indexador = new Indexadores();
             int[] lista = { 1, 2, 3, 4 };

             for (int i = 0; i < lista.Length; i++)
             {
                 indexador[i] = new Indexadores($"Indexador {i}");
             }

             for (int i = 0; i < lista.Length; i++)
             {
                 Console.WriteLine(indexador[i].Mensagem);
             }
            */

            /*Client client = new Client();

            client.ExecutarCriacaoProduto();
            */

            Client client = new Client();
            client.ConsumirDB();

        }
    }
}
