using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personagem
{
    class Personagem
    {
        static void Main(string[] args);
        
            
        public string nome;
        public int din;
        public List<Item> invent = new List<Item>();

        public void AddDin(int valor)
        {
            this.din += valor;
        }
        public void Info()
        {
            Console.WriteLine("Nome: ");
            Console.WriteLine(this.nome);
            Console.WriteLine("Dinheiro");
            Console.WriteLine(this.din);
            Console.WriteLine("Inventário: ");
            Console.WriteLine();

            foreach (Item item in this.invent)
            {

                Console.WriteLine("Nome: " + item.nome);
                Console.WriteLine("Preço: " + item.preco);
                Console.WriteLine("Categoria: " + item.categoria);
                Console.WriteLine("Descriçao: " + item.descricao);
                Console.WriteLine();


            }


        }

    }
}
