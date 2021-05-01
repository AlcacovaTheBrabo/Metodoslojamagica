using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;
            Dictionary<string, Item> itens = new Dictionary<string, Item>();
            Personagem rafhs = new Personagem();
            rafhs.nome = "Rafhs";
            rafhs.dinheiro = 200;


            while (menu)
            {
                Console.WriteLine("1. Registrar Item");
                Console.WriteLine("2. Loja");
                Console.WriteLine("3. Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

               
            }
        }
