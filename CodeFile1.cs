using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace lab4
{
    public enum TransportType
    {
        Велосипед,
        Автомобиль,
        Самолет
    }

    public enum BikeTypes
    {
        Горный, Городской, Детский
    }

    public class Bike : Transport

    {

        public BikeTypes bikeType;
        public int radius = 0;

        public override string GetInfo()
        {
            var str = "";
             str+=base.GetInfo();
            str += $"\n, Радиус колес: {radius}";
            return str;
        }
    }

    public enum CarTypes
    {
        автобус, грузовик, внедорожник, легковая
    }

    public class Auto : Transport
    {
        public CarTypes carType;
        public int EngineCapacity;
        public int DoorsCount;

        public override string GetInfo()
        {
            var str = "Автомобиль";
            str += $"\nТип: {carType}, Объем двигателя: {EngineCapacity}, Количество дверей: {DoorsCount}";
            return str;
        }
    }

    public enum EngineTypes
    {
        Реактивный, Ракетный, Турбовинтовой
    }

    public class Plane : Transport
    {
        public EngineTypes engineType;
        public double FlightHigh;

        public override string GetInfo()
        {
            var str = "Самолет";
            str += $"\nТип двигателя: {engineType}, Высота полета: {FlightHigh}";
            return str;
        }
    }

    public class Transport
    {
        public TransportType type;
        public virtual string GetInfo()
        {
            var str = String.Format("\n Тип: ", this.type);
            return str;
        }
    }
}