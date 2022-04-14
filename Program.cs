using System;

namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дистанцию: ");
            float range = (float)Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите калибр: ");
            double calibre = Convert.ToDouble(Console.ReadLine());

            Weapon gun = new(name, range, calibre);

            Console.WriteLine(gun.Name + " " + gun.Range + " " + gun.Calibre);
        }
    }
    class Weapon
    {
        public string Name;
        public float Range;
        public double Calibre;

        public Weapon(string name, float range, double calibre)
        {
            Name = name;
            Range = range;
            Calibre = calibre;
        }
    }
}
