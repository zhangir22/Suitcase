using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model
{
    class LightCar : ICar
    {
        public double FuelVolume { get; set; }
        public double Speed { get; set; }
        public int AverageFuelConsumption { get; set; }
        public int PowerReserve { get; set; }
        public int Passenger { get; set; }
        public LightCar(double fuelVolume, double speed,int average, int powerReserve, int passenger)
        {
            FuelVolume = fuelVolume;
            Speed = speed;
            AverageFuelConsumption = average;
            PowerReserve = powerReserve;
            Passenger = passenger;
        }

        public double GetMileage(int petrol)
        {
            int mileage  = 0;
            for(int i = petrol; i > 0; i-=AverageFuelConsumption)
            {
                mileage += 100;
            }
            if(Passenger ==0)
                return mileage;
            if(Passenger != 0)
            {
                const int lower = 6;
                int lowerPrecent = 0;
                for(int i = Passenger; i > 0; i--) 
                {
                    lowerPrecent += lower;
                }
                var reminder = (mileage * lowerPrecent) / 100;
                mileage -= reminder;
                return mileage;
            }
            return 0;
        }

        public double GetMileageTime(int distance, int petrol)
        {
            var milage = GetMileage(petrol);
            if(milage > distance)
            {
                return Convert.ToDouble(distance) / Speed;
            }
            if(milage < distance)
            {
                var timeMilage = milage / Speed;
                var timeDistance = Convert.ToDouble(distance) / Speed;
                var reminderTime = timeDistance - timeMilage;
                return reminderTime;
            }
            return 0;
        }

        public void ShowStates()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Состаяние бака {FuelVolume}");
            Console.WriteLine($"Скорость Автомобиля {Speed}");
            Console.WriteLine($"Средний расход топлива {AverageFuelConsumption}");
            Console.WriteLine($"Запас хода {PowerReserve}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
        }
    }
}
