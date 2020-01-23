using System;

namespace VehicleE
{

    /// <summary></summary>
    /// <seealso cref="VehicleE.Transport" />
    public class Moto : Transport
    {
        /// <summary>Initializes a new instance of the <see cref="Moto"/> class.</summary>
        public Moto() { }
        /// <summary>Inputs the car data.</summary>
        public override void InputCarData()
        {
            Moto moto = new Moto();
            {
                Console.WriteLine("Введите Марку мотоцикла");
                moto.Mark = Console.ReadLine();

                Console.WriteLine("Введите Номер мотоцикла");
                moto.Number = Console.ReadLine();

                Console.WriteLine("Введите Скорость мотоцикла(Вводить только число)");
                Console.WriteLine(moto.SpeedTransport() + "Км/ч");

                Console.WriteLine("Введите какой привод у мотоцикла");
                moto.Drive = Console.ReadLine();

                Console.WriteLine("Введите Вес мотоцикла(Вводить только число)");
                Console.WriteLine(moto.WeightTransport() + "Тонн");

                moto.Type = "мотоцикл";
                Reassignment(moto);
            };
        }
    }
    }

