using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp.Model
{
    interface ICar
    {
        /// <summary>
        /// Опишите метод, с помощью которого можно вычислить
        /// сколько автомобиль может проехать на полном баке топлива или
        /// на остаточном количестве топлива в баке на данный момент.
        /// 
        /// 
        /// Метод для отображения текущей информации о состоянии запаса хода в зависимости от пассажиров и груза.
        /// 
        /// 
        /// Метод, который на основе параметров количества топлива и заданного 
        /// расстояния вычисляет за сколько автомобиль его преодолеет
        /// </summary>
        double FuelVolume { get; set; }//Обьем бака
        double Speed { get; set; }//Скорость
        int AverageFuelConsumption { get; set; } //Средний расход топлива
        int PowerReserve { get; set; }//Запас хода
        void ShowStates();
        double GetMileage(int petrol );//Вычесление
        double GetMileageTime(int distance, int petrol/*Топливо*/);

    }
}
