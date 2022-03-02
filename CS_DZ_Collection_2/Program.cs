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

            int check = 0;

            payClients.Enqueue(100);
            payClients.Enqueue(20);
            payClients.Enqueue(9);
                
            for (int i = -2; i < payClients.Count; i++)
            {
                Console.WriteLine("Произошла оплата - " + payClients.Peek() + "\nУ нас на счету - " + (check += payClients.Dequeue()));
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
