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

            payClients.Enqueue(100);
            payClients.Enqueue(20);
            payClients.Enqueue(9);

            int check = 0;

            foreach (var item in payClients)
            {
                check = item + check;
                Console.WriteLine("Произошла оплата - " + item + "\nУ нас на счету - " + check);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
