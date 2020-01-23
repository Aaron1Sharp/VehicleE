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
            transports.Add(new Car { Type = transport.Type, Mark = transport.Mark, Number = transport.Number, Speed = transport.Speed, Pram = transport.Pram, Weight = transport.Weight });
        }
        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String"/> that represents this instance.</returns>
        public override string ToString()
        {
            return $"-------------\nТип авто = {Type}\nмарка = {Mark}\nномер = {Number }\nскорость = {Speed}км/ч\nколяска = {Pram}\nвес = {Weight}Кг\n-------------";
        }
        /// <summary>Reassignments the specified transport.</summary>
        /// <param name="transport">The transport.</param>
        public void Reassignment(Transport transport)
        {
            Mark = transport.Mark;
            Number = transport.Number;
            Speed = transport.Speed;
            Pram = transport.Pram;
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
        public string Pram { get; set; }
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
    }
}

