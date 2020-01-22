using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleE
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Mark1","Number1",2,"true",54);
            Console.WriteLine(car);
            Console.ReadKey();
            
            
        }
    }
   public abstract class Transport
    {
        public override string ToString()
        {
            return $"марка = {Mark = Convert.ToString(Console.ReadLine())},номер = {Number = Convert.ToString(Console.ReadLine())},скорость = {Speed = Convert.ToInt32(Console.ReadLine())}, коляска = {Pram = Convert.ToString(Console.ReadLine())}, вес = {Weight = Convert.ToDouble(Console.ReadLine())}";
        }
        public string Mark { get; set; }
        public string Number { get; set; }
        public int Speed { get; set; }
        public string Pram { get; set; }
        public double Weight { get; set; }
        public Transport(string mark, string number, int speed, string pram, double weight)
        {
            this.Mark = mark;
            this.Number = number;
            this.Speed = speed;
            this.Pram = pram;
            this.Weight = weight;
        }
        public abstract void ShowMark();
        public abstract void ShowNumber();
        public abstract void ShowSpeed();
        public abstract void ShowPram();
        public abstract void ShowWeight();
    }
   public class Car : Transport
    {
        public Car(string mark, string number, int speed, string pram, double weight) : base(mark, number, speed, pram, weight)
        {

        }

        public override void ShowMark()
        {
            Console.WriteLine("mark = Class.Car");
        }

        public override void ShowNumber()
        {
            Console.WriteLine("Number = Class.Car");
        }

        public override void ShowPram()
        {
            Console.WriteLine("Pram.false = Class.Car");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine("Speed.300km = Class.Car");
        }

        public override void ShowWeight()
        {
            Console.WriteLine("Weight.2T = Class.Car");
        }
    }
    public class Truck : Transport
    {
        public Truck(string mark, string number, int speed, string pram, double weight) : base(mark, number, speed, pram, weight)
        {

        }

        public override void ShowMark()
        {
            Console.WriteLine("mark = Class.Truck");
        }

        public override void ShowNumber()
        {
            Console.WriteLine("Number = Class.Truck");
        }

        public override void ShowPram()
        {
            Console.WriteLine("Pram.True = Class.Truck");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine("Speed = Class.Truck");
        }

        public override void ShowWeight()
        {
            Console.WriteLine("Weight = Class.Truck");
        }
    }
    public class Moto : Transport
    {
        public Moto(string mark, string number, int speed, string pram, double weight) : base(mark, number, speed, pram, weight)
        {

        }
        public override void ShowMark()
        {
            Console.WriteLine("mark = Class.Moto");
        }

        public override void ShowNumber()
        {
            Console.WriteLine("Number = Class.Moto");
        }

        public override void ShowPram()
        {
            Console.WriteLine("Pram.True = Class.Moto");
        }

        public override void ShowSpeed()
        {
            Console.WriteLine("Speed = Class.Moto");
        }

        public override void ShowWeight()
        {
            Console.WriteLine("Weight = Class.Moto");
        }
    }
}
