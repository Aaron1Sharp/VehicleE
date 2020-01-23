using System;

namespace VehicleE
{

    /// <summary></summary>
    /// <seealso cref="VehicleE.Transport" />
    public class Truck : Transport
        {
        /// <summary>Initializes a new instance of the <see cref="Truck"/> class.</summary>
        public Truck() { }
        /// <summary>Inputs the car data.</summary>
        public override void InputCarData()
        {
            Truck truck = new Truck();
            {
                Console.WriteLine("Введите Марку грузовика");
                truck.Mark = Console.ReadLine();

                Console.WriteLine("Введите Номер грузовика");
                truck.Number = Console.ReadLine();

                Console.WriteLine("Введите Скорость грузовика(Вводить только число)");
                Console.WriteLine(truck.SpeedTransport() + "Км/ч");

                Console.WriteLine("Введите какой привод у грузовика");
                truck.Pram = Console.ReadLine();

                Console.WriteLine("Введите Вес грузовика(Вводить только число)");
                Console.WriteLine(truck.WeightTransport() + "Тонн");

                truck.Type = "грузовик";
                Reassignment(truck);
            };
        }
        }
    }

