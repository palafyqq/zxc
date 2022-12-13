using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22222222
{
    public class Computers
    {
        public string pitanie;
        public string pamyat;
        public string cpu;
        public string gpu;
        public string diagonal_monitor;
        
        public void create_computers()
        {
            Console.Write("Укажите сколько потребляет компьютера: ");
            pitanie = Console.ReadLine();
            Console.Write("Укажите память компьютера: ");
            pamyat = Console.ReadLine();
            Console.Write("Укажите процессор компьютера: ");
            cpu = Console.ReadLine();
            Console.Write("Укажите видеокарту/виидеочип компьютера: ");
            gpu = Console.ReadLine();
            Console.Write("Укажите диагональ монитора компьютера: ");
            diagonal_monitor = Console.ReadLine();

        }
        
        public void Computers_info()
        {
            Console.WriteLine($"Питание компьютера - {pitanie}");
            Console.WriteLine($"Память компьютера - {pamyat}");
            Console.WriteLine($"процессор компьютера - {cpu}");
            Console.WriteLine($"видеокарта/виидеочип компьютера - {gpu}");
            Console.WriteLine($"диагональ монитора компьютера - {diagonal_monitor}");
        }
    }

    public class PC : Computers
    {
        private int blok_pitaniya;
        private int korpys;
        public void PC_create()
        {
            Console.Write("Укажите тип корпуса(открытый/закрытый): ");
            korpys = Convert.ToInt32(Console.ReadLine());
            Console.Write("Укажте мощность блока питаня: ");
            blok_pitaniya = Convert.ToInt32(Console.ReadLine());
        }

        public void PC_imfo()
        {
            Console.WriteLine($"Тип корпуса - {korpys}");
            Console.WriteLine($"Мощность БК - {blok_pitaniya}");
        }

        public class Laptop : Computers
        {
            private int model;
            private int ves;

            public void create_Laptop()
            {
                Console.Write("Укажите модель ноутбука: ");
                model = Convert.ToInt32(Console.ReadLine());
                Console.Write("Укажите вес ноутбука: ");
                ves = Convert.ToInt32(Console.ReadLine());
            }
            
    public void Laptop_info()
            {
                Console.WriteLine($"Вес - {ves}");
                Console.WriteLine($"Модель - {model}");
            }
        }
    }
}
