using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model
{
    class CargoCar : ICar
    {
        public double FuelVolume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AverageFuelConsumption { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int PowerReserve { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Cargo { get; set; }
        public double GetMileage(int petrol)
        {
            int mileage = 0;
            for (int i = petrol; i > 0; i -= AverageFuelConsumption)
            {
                mileage += 100;
            }
            if(Cargo == 0)
                return mileage;
            if(Cargo != 0)
            {
                int lower = 4;
                int lowerPrecent = 0;
                int ceiling = 200;
                for(int i = Cargo; i > 0; i -= ceiling)
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
            if (milage > distance)
            {
                return Convert.ToDouble(distance) / Speed;
            }
            if (milage < distance)
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
