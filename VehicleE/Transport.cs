using System;
using System.Collections.Generic;

namespace VehicleE
{
    /// <summary></summary>
    public abstract class Transport
    {
        /// <summary>Adds to list.</summary>
        /// <param name="transports">The transports.</param>
        /// <param name="transport">The transport.</param>
        public static void AddToList(List<Transport> transports, Transport transport)
        {
            transports.Add(new Car { Type = transport.Type, Mark = transport.Mark, Number = transport.Number, Speed = transport.Speed, Drive = transport.Drive, Weight = transport.Weight });
        }
        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            return $"-------------\nТип авто = {Type}\nмарка = {Mark}\nномер = {Number }\nскорость = {Speed}км/ч\nПривод = {Drive}\nвес = {Weight}Кг\n-------------";
        }
        /// <summary>Reassignments the specified transport.</summary>
        /// <param name="transport">The transport.</param>
        public void Reassignment(Transport transport)
        {
            Mark = transport.Mark;
            Number = transport.Number;
            Speed = transport.Speed;
            Drive = transport.Drive;
            Weight = transport.Weight;
            Type = transport.Type;
        }
        /// <summary>Inputs the car data.</summary>
        public abstract void InputCarData();
        /// <summary>Gets or sets the type.</summary>
        /// <value>The type.</value>
        public string Type { get; set; }
        /// <summary>Gets or sets the mark.</summary>
        /// <value>The mark.</value>
        public string Mark { get; set; }
        /// <summary>Gets or sets the number.</summary>
        /// <value>The number.</value>
        public string Number { get; set; }
        /// <summary>Gets or sets the speed.</summary>
        /// <value>The speed.</value>
        public int Speed { get; set; }
        /// <summary>Gets or sets the pram.</summary>
        /// <value>The pram.</value>
        public string Drive { get; set; }
        /// <summary>Gets or sets the weight.</summary>
        /// <value>The weight.</value>
        public double Weight { get; set; }
        public double weight;
        public int speed;
        /// <summary>Speeds the transport.</summary>
        /// <returns></returns>
        public int SpeedTransport()
        {
            while (!int.TryParse(Console.ReadLine(), out speed))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }  
            return Speed = speed;
        }
        /// <summary>Weights the transport.</summary>
        /// <returns></returns>
        public double WeightTransport()
        {
            while (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            return Weight = weight;
        } 
         /// <summary>Starts the action vehicle.</summary>
        public static void StartActionVehicle()
        {
            List<Transport> transports = new List<Transport>();
            bool startAction = true;
            while (startAction)
            {
                Console.WriteLine("!что бы выйти введите = закончить!\nкакие данные вы хотите добавить? \n введите тип автомобиля \n машина грузовик мотоцикл\nчто бы начать поиск введите = поиск");
                string input = Console.ReadLine();
                string actionSelectionCar = "машина";
                string actionSelectionTruck = "грузовик";
                string actionSelectionMoto = "мотоцикл";
                string find = "поиск";
                string end = "закончить";
                
                if (input == actionSelectionCar)
                {
                    Car car = new Car();
                    car.InputCarData();
                    AddToList(transports, car);
                }

                else if (input == actionSelectionTruck)
                {
                    Truck truck = new Truck();
                    truck.InputCarData();
                    AddToList(transports, truck);
                }

                else if (input == actionSelectionMoto)
                {
                    Moto moto = new Moto();
                    moto.InputCarData();
                    AddToList(transports, moto);
                }

                else if (input == end)
                {
                    startAction = false;
                }
                Console.Clear();
                foreach (Transport aPart in transports)
                {
                    Console.WriteLine(aPart);
                }

                 if (input == find)
                 {
                    Console.WriteLine("Введите слово для поиска");
                    string search = Console.ReadLine();
                    Console.WriteLine($"\nFind: Part where name contains -{search}-:\n-------------"+transports.Find(transport => transport.Mark.Contains(search))) ;

                 }
            }
        }
    }
}

