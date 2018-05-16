using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Classes
{
    class Vehicle
    {
        public string model;
        public double engine;
        public int year;

        public Vehicle()
        {

        }
        
        public Vehicle(string model, double engine, int year)
        {
            this.model = model;
            this.engine = engine;
            this.year = year;
        }        

        public virtual void About()
        {
            Console.WriteLine("{0} {1} {2}", model, engine, year);
        }
    }

    class Audi : Vehicle
    {
        public string color;

        public Audi(string model, double engine, int year):base(model, engine, year)
        {

        }

        public new void About()
        {
            Console.WriteLine("Audi {0} {1} {2} {3}", model, engine, year, color);
        }
    }

    class TypeR : Audi
    {
        public bool turbo;

        public TypeR(string model, double engine, int year) : base(model, engine, year)
        {

        }

        public new void About()
        {
            Console.WriteLine("Audi {0} {1} {2} {3}. Contain turbo: {4}", model, engine, year, color, turbo);
        }
    }

    class Honda : Vehicle
    {
        public int doors;

        public Honda(string model, double engine, int year) : base(model, engine, year)
        {

        }

        public new void About()
        {
            Console.WriteLine("Honda {0} {1} {2}. Contain doors: {3}", model, engine, year, doors);
        }
    }

    class TypesS: Honda
    {
        public bool sunroof;

        public TypesS(string model, double engine, int year) : base(model, engine, year)
        {

        }

        public new void About()
        {
            Console.WriteLine("Honda {0} {1} {2}. Contain doors: {3}. Contain sunroof: {4}", model, engine, year, doors, sunroof);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TypesS Accord = new TypesS("Accord", 2.4, 2005);
            Accord.doors = 4;
            Accord.sunroof = true;

            Accord.About();

            TypeR A6 = new TypeR("A6", 3.0, 2006);
            A6.color = "Black";
            A6.turbo = true;

            A6.About();

            Console.ReadKey();

        }
    }
}
