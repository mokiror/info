using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace info
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //01
            Console.WriteLine("Введите своё имя: ");
            string usersName = Console.ReadLine(); 
            Console.WriteLine("Введите свой возраст: ");
            int usersAge = int.Parse(Console.ReadLine());

            if (usersAge > 18)
            {
                foreach (var ch in usersName)
                {
                    Console.WriteLine($"Ваше имя: {ch}");
                }
                Console.WriteLine($"Ваш возраст: {usersAge} ");
            }
            else if( usersAge <= 18 )
            {
                foreach (var ch in usersName)
                {
                    Console.WriteLine($"Твоё имя: {ch}");
                }
                Console.WriteLine($"Твой возраст: {usersAge} ");
            }

            //03
            Console.WriteLine("\nВведите своё имя: ");
            string usersName2 = Console.ReadLine();
            Console.WriteLine("Введите свой возраст: ");
            int usersAge2 = int.Parse(Console.ReadLine());

            if (usersAge2 > 18)
            {
                char[] arr = usersName2.ToCharArray();
                int last = arr.Length - 1;
                Console.WriteLine("\nВаше имя наоборот: ");
                for (int n = last; n >= 0; n--)
                {
                    Console.Write(arr[n]);
                }
                Console.WriteLine($"\nВаш возраст: {usersAge2} ");
            }
            else if (usersAge2 <= 18)
            {
                char[] arr = usersName2.ToCharArray();
                int last = arr.Length - 1;
                Console.WriteLine("Твоё имя наоборот: ");
                for (int n = last; n >= 0; n--)
                {
                    Console.Write(arr[n]);
                }
                Console.WriteLine($"\nТвой возраст: {usersAge2} ");
            }

            //02
            Console.WriteLine("\nВведите первый аргумент: ");
            string usersName3 = Console.ReadLine();
            Console.WriteLine("Введите второй аргумент: ");
            int usersAge3 = int.Parse(Console.ReadLine());

            if (usersAge3 > 18)
            {
                foreach (var chhh in usersName3)
                {
                    Console.WriteLine($"Ваше имя: {chhh}");
                }
                Console.WriteLine($"Ваш возраст: {usersAge3} ");
            }
            else if (usersAge3 <= 18)
            {
                foreach (var chhh in usersName3)
                {
                    Console.WriteLine($"Твоё имя: {chhh}");
                }
                Console.WriteLine($"Твой возраст: {usersAge3} ");
            }


            Console.ReadKey();
        }
    }
}
