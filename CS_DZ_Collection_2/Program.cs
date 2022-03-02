using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_DZ_Collection_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> payClients = new Queue<int>();

            int money = 0;

            payClients.Enqueue(100);
            payClients.Enqueue(20);
            payClients.Enqueue(9);

            int clients = payClients.Count;
                
            for (int i = 0; i < clients; i++)
            {
                Console.Write("Произошла оплата - " + payClients.Peek());

                money += payClients.Dequeue();

                Console.WriteLine("\nУ нас на счету - " + money);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
