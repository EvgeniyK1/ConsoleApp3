using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дистанционка, от 25.10

            char array = 'n';
            Random rnd = new Random();

            while (array == 'n')
            {
                int i = rnd.Next(10);
                Console.WriteLine("Компьютер загадал число от 0 до 10");
                Console.WriteLine("Введите число");

                int x = Convert.ToInt32(Console.ReadLine());

                if (i == x)
                    Console.WriteLine("Вы угадали число");
                else
                    Console.WriteLine("Вы не угадали, это число {0}", i);
                Console.WriteLine("Еще попытку? (n = Да, n = Нет");
                array = Convert.ToChar(Console.ReadLine());



            }











        }
    }
}
