using System;
using System.Collections.Generic;

namespace VehicleE
{
    class ShowProgram
    {
        /// <summary>Starts the action vehicle.</summary>
        public static void StartActionVehicle()
        {

            List<Transport> transports = new List<Transport>();
            bool startAction = true;

            while (startAction)
            {
                Console.WriteLine("!что бы выйти введите = закончить!\nкакие данные вы хотите добавить? \n введите тип автомобиля \n машина грузовик мотоцикл");
                string input = Console.ReadLine();
                string actionSelectionCar = "машина";
                string actionSelectionTruck = "грузовик";
                string actionSelectionMoto = "мотоцикл";
                string end = "закончить";

                if (input == actionSelectionCar)
                {
                    Car car = new Car();
                    car.InputCarData();

                    Transport.AddToList(transports, car);
                }

                else if (input == actionSelectionTruck)
                {
                    Truck truck = new Truck();
                    truck.InputCarData();

                    Transport.AddToList(transports, truck);
                }

                else if (input == actionSelectionMoto)
                {
                    Moto moto = new Moto();
                    moto.InputCarData();

                    Transport.AddToList(transports, moto);
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
            }
        }
    }
    
}

