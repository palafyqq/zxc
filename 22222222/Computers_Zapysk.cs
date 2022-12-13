using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _22222222;
using static _22222222.PC;

namespace Prac7
{
    internal class Program
    {
        static void fio()
        {
            string fio = "Работу выполнили суденты группы ИСИП-2-21 Стаканов Евгений и Хохлов Степан";
            Console.WriteLine(fio);
        }
        static void hash()
        {
            string hash = "#########################################################################";
            Console.WriteLine(hash);
        }

        private static void Main(string[] args)
        {
            int i, n;
            fio();
            hash();
            Console.WriteLine("Самостаятельная работа №2, вариант5, задание4");
            hash();
            Console.Write("Добро пожаловать в программу создания компьютеров\nУкажите сколько настольных компьютеров вы хотите создать: ");
            n = Convert.ToInt32(Console.ReadLine());
            hash();
            PC[] Comp1 = new PC[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}) настольный компьютер: ");
                Comp1[i] = new PC();
                Comp1[i].create_computers();
                Comp1[i].PC_create();
                hash();
            }


            Console.Write("Укажите сколько ноутбуков вы хотите создать: ");
            n = Convert.ToInt32(Console.ReadLine());
            hash();
            Laptop[] lap1 = new Laptop[n];
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}) ноутбук: ");
                lap1[i] = new Laptop();
                lap1[i].create_computers();
                lap1[i].create_Laptop();

                hash();
            }
            Console.Clear();
            fio();
            hash();
            Console.WriteLine("Практическая работа №7. задание 1");
            hash();
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}) настольный компьютер: ");
                Comp1[i].Computers_info();
                Comp1[i].PC_imfo();
                hash();
            }
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}) ноутбук: ");
                lap1[i].Computers_info();
                lap1[i].Laptop_info();
                hash();
            }
        }
    }
}
