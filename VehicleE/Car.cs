using System;

namespace VehicleE
{
    public class Car : Transport
    {
    public Car() { }
        public override void InputCarData()
        {
            Car car = new Car();
            {
                Console.WriteLine("Введите Марку авто");
                car.Mark = Console.ReadLine();

                Console.WriteLine("Введите Номер авто");
                car.Number = Console.ReadLine();

                Console.WriteLine("Введите Скорость авто(Вводить только число)");
                Console.WriteLine(car.SpeedTransport()+"Км/ч");

                Console.WriteLine("Введите какой привод у авто");
                car.Pram = Console.ReadLine();

                Console.WriteLine("Введите Вес авто (Вводить только число)");
                Console.WriteLine(car.WeightTransport() + "Тонн");

                car.Type = "Легковая машина";
                Reassignment(car);
            }; 
        }
    }
}

