using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Паттерн Abstaract Factory");
            Console.WriteLine("Введите количество создаваемых элементов:");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (amount != 0)
            {
                Console.WriteLine("Введите тип создаваемого объекта (1- Sniper, 2 - Assault, 3 - Support)");
                int type = Convert.ToInt32(Console.ReadLine());
                if (type == 1)
                {
                    Soldier snipe = new Soldier(new SniperFactory());
                    snipe.Hit();
                    snipe.Utility();
                }
                else if (type == 2)
                {
                    Soldier aslt = new Soldier(new AssaultFactory());
                    aslt.Hit();
                    aslt.Utility();
                }
                else if (type == 3)
                {
                    Soldier sprt = new Soldier(new SupportFactory());
                    sprt.Hit();
                    sprt.Utility();
                }
                else throw new Exception("Данные введены неправильно");

                amount--;
            }

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Singleton");
            Squad squad = new Squad();
            squad.Assing("Петров");
            Console.WriteLine("Командиром отряда назначен "+squad.Commandor.LastName);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Builder");
            
            Creator creator = new Creator();
            
            LocationBuilder builder = new MountainLocation();

            Location mountains = creator.Create(builder);
            Console.WriteLine(mountains.ToString());

            builder = new FlatLocation();
            Location flatlocation = creator.Create(builder);
            Console.WriteLine(flatlocation.ToString());

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Prototype");
            IVehicle vehicle = new Tank(50, 60);
            IVehicle clonedvehicle = vehicle.Clone();
            vehicle.GetInfo();
            clonedvehicle.GetInfo();

            vehicle = new Car(80,6);
            clonedvehicle = vehicle.Clone();
            vehicle.GetInfo();
            clonedvehicle.GetInfo();





            Console.ReadKey();
        }
    }
    //------------------------------------------------------------------------------------------------
    class Squad
    {
        public Commandor Commandor { get; set; }
        public void Assing(string CommandorLastName)
        {
            Commandor = Commandor.getInstance(CommandorLastName);
        }
    }
    class Commandor
        {
            private static Commandor instance;

            public string LastName { get; private set; }

            protected Commandor(string lastname)
            {
                this.LastName = lastname;
            }

            public static Commandor getInstance(string lastname)
            {
                if (instance == null)
                    instance = new Commandor(lastname);
                return instance;
            }
        }
        //------------------------------------------------------------------------------------------------
        abstract class Weapon
        {
            public abstract void Hit();
        }

        abstract class Utility
        {
            public abstract void Use();
        }
        class Rifle : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Выстрел из штурмовой винтовки");
            }
        }
        class SniperRifle : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Выстрел из снайперской винтовки");
            }
        }
        class Machinegun : Weapon
        {
            public override void Hit()
            {
                Console.WriteLine("Выстрел из пулемета");
            }
        }
        class HealUtility : Utility
        {
            public override void Use()
            {
                Console.WriteLine("Использована аптечка");
            }
        }
        class ExplodeUtility : Utility
        {
            public override void Use()
            {
                Console.WriteLine("Использована взрывчатка");
            }
        }
        class AmmoUtility : Utility
        {
            public override void Use()
            {
                Console.WriteLine("Использован ящик с боеприпасами");
            }
        }
        abstract class SoldierFactory
        {
            public abstract Utility CreateUtility();
            public abstract Weapon CreateWeapon();
        }
        class AssaultFactory : SoldierFactory 
        {
            public override Weapon CreateWeapon()
            {
                return new Rifle();
            }
            public override Utility CreateUtility()
            {
                return new ExplodeUtility();
            }
        }
        class SniperFactory : SoldierFactory
        {
            public override Weapon CreateWeapon()
            {
                return new SniperRifle();
            }
            public override Utility CreateUtility()
            {
                return new HealUtility();
            }
        }
        class SupportFactory : SoldierFactory
        {
            public override Weapon CreateWeapon()
            {
                return new Machinegun();
            }
            public override Utility CreateUtility()
            {
                return new AmmoUtility();
            }
        }
        class Soldier
        {
            private Weapon weapon;
            private Utility utility;
            public Soldier(SoldierFactory factory)
            {
                weapon = factory.CreateWeapon();
                utility = factory.CreateUtility();
            }
            public void Utility()
            {
                utility.Use();
            }
            public void Hit()
            {
                weapon.Hit();
            }
        }
        //------------------------------------------------------------------------------------------------
        class Landskape
        {
            public string LandskapeType { get; set; }
        }

        class Weather
        {
            public string WeatherType { get; set; }
        }

        class DayTime
        {
            public string DayTimeType { get; set; }
        }
        class Location
        {

            public Landskape Landskape { get; set; }

            public Weather Weather { get; set; }

            public DayTime DayTime { get; set; }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                if (Landskape != null)
                    sb.Append("Tип ландшафта:" + Landskape.LandskapeType + "\n");
                if (Weather != null)
                    sb.Append("Погодные условия:" + Weather.WeatherType + "\n");
                if (DayTime != null)
                    sb.Append("Время дня:" + DayTime.DayTimeType + "\n");
                return sb.ToString();
            }
        }
        abstract class LocationBuilder //билдер
        {
            public Location Location { get; private set; }
            public void CreateLocation()
            {
                Location = new Location();
            }
            public abstract void SetLandskape();
            public abstract void SetWeather();
            public abstract void SetDayTime();
        }

        class Creator //директор
        {
            public Location Create(LocationBuilder locationBuilder)
            {
                locationBuilder.CreateLocation();
                locationBuilder.SetLandskape();
                locationBuilder.SetWeather();
                locationBuilder.SetDayTime();
                return locationBuilder.Location;
            }
        }
        class MountainLocation : LocationBuilder
        {
            public override void SetLandskape()
            {
                this.Location.Landskape = new Landskape { LandskapeType = "Горная местность" };
            }

            public override void SetWeather()
            {
                this.Location.Weather = new Weather { WeatherType = "Метель" };
            }

            public override void SetDayTime()
            {
                this.Location.DayTime = new DayTime { DayTimeType = "Утро" };
            }
        }
        class FlatLocation : LocationBuilder
        {
            public override void SetLandskape()
            {
                this.Location.Landskape = new Landskape { LandskapeType = "Равнинная местность" };
            }

            public override void SetWeather()
            {
                this.Location.Weather = new Weather { WeatherType = "Сильный ливень" };
            }

            public override void SetDayTime()
            {
                this.Location.DayTime = new DayTime { DayTimeType = "Ночь" };
            }
        }
        //------------------------------------------------------------------------------
        interface IVehicle
        {

        IVehicle Clone();
            void GetInfo();
        }
    class Tank : IVehicle
        {
            int speed;
            int weight;
            public Tank(int s, int w)
            {
                speed = s;
                weight = w;
            }

        public Tank()
        {
            throw new System.NotImplementedException();
        }

        public IVehicle Clone()
            {
                return new Tank(this.speed, this.weight);
            }
            public void GetInfo()
            {
                Console.WriteLine(" Масса танка: {0}; Максимальная скорость танка: {1}", weight, speed);
            }

        }
    class Car : IVehicle
        {
            int speed;
            int capacity;
            public Car(int s, int c)
            {
                speed = s;
                capacity = c;
            }

        public Car()
        {
            throw new System.NotImplementedException();
        }

        public IVehicle Clone()
            {
                return new Car(this.speed, this.capacity);
            }
            public void GetInfo()
            {
                Console.WriteLine(" Максимальная скорость машины: {0}; Вместимость (человек): {1}", speed, capacity);
            }

        }
}
