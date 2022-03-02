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
            Dictionary<string, int> payClients = new Dictionary<string, int>();

            payClients.Add("Вася", 100);
            payClients.Add("Маша", 20);
            payClients.Add("Петр", 9);

            int check = 0;

            foreach (var item in payClients)
            {
                check = item.Value + check;
                Console.WriteLine("Заплатил клиент - " + item.Key + "\nУ нас на счету - " + check);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
