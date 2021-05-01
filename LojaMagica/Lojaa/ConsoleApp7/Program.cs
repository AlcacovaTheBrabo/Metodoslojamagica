using System;
using System.Collections.Generic;

namespace Lojamagmetodos
{
    public class Item
    {
        
        public string nome, des, cat;
        public int preco;
        public Item Registrar()
        {


            Console.WriteLine("Registro de item");
            Console.WriteLine();
            Item item = new Item();

            Console.WriteLine("Nome: ");
            item.nome = Console.ReadLine();

            Console.WriteLine("Descricao: ");
            item.des = Console.ReadLine();

            Console.WriteLine("Categoria: ");
            item.cat = Console.ReadLine();

            Console.WriteLine("Preco: ");
            item.preco = Convert.ToInt32(Console.ReadLine());



            return item;


        }


    }
 }