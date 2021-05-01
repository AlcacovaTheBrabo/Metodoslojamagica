using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a Loja!");
            Console.WriteLine();

            foreach (Item item in item.Values)
            {



                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("Preço: " + item.preco);
                Console.WriteLine("Categoria: " + item.cat);
                Console.WriteLine("Descriçao: " + item.des);
                Console.WriteLine();


            }
            Console.WriteLine("Escolha um item com a sua vontade e dinheiro!");
            Console.WriteLine();

            string id = Console.ReadLine();

                Item compra = item[id];

                if (rafhs.dinheiro < compra.preco)
                {

                    Console.WriteLine("Você não possui dinheiro suficiente, cumpra os desafios e consiga!");

                }
                else
                {
                    rafhs.inventario.Add(compra);
                    rafhs.dinheiro -= compra.preco;
                    Console.WriteLine(rafhs.nome + " comprou " + compra.nome);


                }


        }
    }
}
