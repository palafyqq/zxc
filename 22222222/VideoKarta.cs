using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22222222
{
    class Videokarta
    {
        public string pam;
        public string chastota;
        public string nazv;
        public string napr_pit;
        public string shina;
        public void Create_Kart()
        {
            Console.Write("Напишите название видеокарты: ");
            nazv = Console.ReadLine();
            Console.Write("Напишите частоту памяти: ");
            chastota = Console.ReadLine();
            Console.Write("Напишите разрядность шины: ");
            shina = Console.ReadLine();
            Console.Write("Напишите напряжения питания памяти: ");
            napr_pit = Console.ReadLine();
            Console.Write("Напишите объем памяти: ");
            pam = Console.ReadLine();
        }
        public void Kart_info()
        {
            Console.WriteLine($"Название видеокарты: {nazv}");
            Console.WriteLine($"Частота: {chastota}");
            Console.WriteLine($"Разрядность шины: {shina}");
            Console.WriteLine($"Напряжение питания: {napr_pit}");
            Console.WriteLine($"Размер памяти: {pam}");
        }
        static void Main(string[] args)
        {
            string fio = "";
            int i, n;
            string hash = "##############################################################################################";
            Console.WriteLine(fio);
            Console.WriteLine(hash);
            Console.WriteLine("Самостаятельная работа №2 Вариант5 Задание3");
            Console.WriteLine(hash);
            Console.WriteLine("Сколько видеокарт хотите создать?: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hash);
            Videokarta[] vidkarts = new Videokarta[n];
            for (i = 0; i < n; i++) ;
            {
                Console.WriteLine($"{i + 1} видеокарта: ");
                vidkarts[i] = new Videokarta();
                vidkarts[i].Create_Kart();
                Console.WriteLine(hash);
                vidkarts[i].Kart_info();
                Console.WriteLine(hash);
            }
        }
    }
}
