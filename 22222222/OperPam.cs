using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22222222
{
    class Operpam
    {
        public string op_pam;
        public string chastota;
        public string tip_pam;
        public string napr_pit;
        public void Create_OperPam()
        {
            Console.Write("Напишите тип оперативной памяти: ");
            tip_pam = Console.ReadLine();
            Console.Write("Напишите частоту памяти: ");
            chastota = Console.ReadLine();
            Console.Write("Напишите объем памяти: ");
            op_pam = Console.ReadLine();
            Console.Write("Напишите напряжения питания памяти: ");
            napr_pit = Console.ReadLine();
        }
        public void OperPam_info()
        {
            Console.WriteLine($"Тип памяти: {tip_pam}");
            Console.WriteLine($"Частота частота: {chastota}");
            Console.WriteLine($"Объем памяти: {op_pam}");
            Console.WriteLine($"Напряжение питания: {napr_pit}");
        }
        static void Main(string[] args)
        {
            string fio = "";
            int i, n;
            string hash = "##############################################################################################";
            Console.WriteLine(fio);
            Console.WriteLine(hash);
            Console.WriteLine("Самостаятельная работа №2 Вариант5 Задание2");
            Console.WriteLine(hash);
            Console.WriteLine("Сколько процессоров хотите создать?: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hash);
            Operpam[] operpams = new Operpam[n];
            for (i = 0; i < n; i++) ;
            {
                Console.WriteLine($"{i + 1} память: ");
                operpams[i] = new Operpam();
                operpams[i].Create_OperPam();
                Console.WriteLine(hash);
                operpams[i].OperPam_info();
                Console.WriteLine(hash);
            }
        }
    }
}
