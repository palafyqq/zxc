using System;

namespace _22222222
{
    class Centralproc
    {
        public string seria;
        public string chastota;
        public string kolvo_yad;
        public void Create_CentralProc()
        {
            Console.Write("Напишите серию процессора: ");
            seria = Console.ReadLine();
            Console.Write("Напишите частоту процессора: ");
            chastota = Console.ReadLine();
            Console.Write("Напишите количество ядер процессора: ");
            kolvo_yad = Console.ReadLine();
        }
        public void Centralproc_info()
        {
            Console.WriteLine($"Серия процессора: {seria}");
            Console.WriteLine($"Частота процессора: {chastota}");
            Console.WriteLine($"Количество ядер процессора: {kolvo_yad}");
        }
        static void Main(string[] args)
        {
            string fio = "";
            int i, n;
            string hash = "##############################################################################################";
            Console.WriteLine(fio);
            Console.WriteLine(hash);
            Console.WriteLine("Самостаятельная работа №2 Вариант5 Задание1");
            Console.WriteLine(hash);
            Console.WriteLine("Сколько процессоров хотите создать?: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(hash);
            Centralproc[] centrprocs = new Centralproc[n];
            for (i = 0; i < n; i++);
            {
                Console.WriteLine($"{i + 1} процессор: ");
                centrprocs[i] = new Centralproc();
                centrprocs[i].Create_CentralProc();
                Console.WriteLine(hash);
                centrprocs[i].Centralproc_info();
                Console.WriteLine(hash);
            }
        }
    }
   


        
    
}
