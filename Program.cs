using System;

namespace pract1
{
    class Program
    {
        static void Main(string[] args)
        {

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
