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
        public TransportType Type = TransportType.Велосипед;
        public BikeTypes bikeType;
        public int radius = 0;

        public override string GetInfo()
        {
            var str = base.GetInfo();
            str += $"\nТип велосипеда: {bikeType},\nРадиус колес: {radius}";
            return str;
        }


        public static Bike Generate()
        {
          
            return new Bike
            {
                Type = TransportType.Велосипед,
                bikeType = (BikeTypes)rnd.Next(Enum.GetValues(typeof(BikeTypes)).Length),
                radius = rnd.Next(10, 31)
            };
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
            var str = base.GetInfo();
            str += $"\nТип автомобиля: {carType},\nОбъем двигателя: {EngineCapacity},\nКоличество дверей: {DoorsCount}";
            return str;
        }

        public static Auto Generate()
        {
         
            return new Auto
            {
                Type = TransportType.Автомобиль,
                carType = (CarTypes)rnd.Next(Enum.GetValues(typeof(CarTypes)).Length),
                EngineCapacity = rnd.Next(101),
                DoorsCount = rnd.Next(3, 6)
            };
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
            var str = base.GetInfo();
            str += $"\nТип двигателя самолета: {engineType},\nВысота полета: {FlightHigh}";
            return str;
        }


        public static Plane Generate()
        {
            
            return new Plane
            {
                Type = TransportType.Самолет,
                engineType = (EngineTypes)rnd.Next(Enum.GetValues(typeof(EngineTypes)).Length),
                FlightHigh = rnd.NextDouble() * 10000
            };
        }

    }

    public class Transport
    {
        public TransportType Type;
        public static Random rnd = new Random();
        public virtual string GetInfo()
        {
            return $"Тип транспорта: {Type} ";
        }
    }
}
