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
                    Soldier snipe = new Soldier(new Sniper());
                    snipe.Hit();
                    snipe.Utility();
                }
                else if (type == 2)
                {
                    Soldier aslt = new Soldier(new Assault());
                    aslt.Hit();
                    aslt.Utility();
                }
                else if (type == 3)
                {
                    Soldier sprt = new Soldier(new Support());
                    sprt.Hit();
                    sprt.Utility();
                }
                else throw new Exception("Данные введены неправильно");

                amount--;
            }
            var map = new Map { Title = "Army" };


            Sniper sniper = new Sniper() { Title = "Снайпер" };
            Assault assault = new Assault() { Title = "Штурмовик" };
            Support support = new Support() { Title = "Поддержка" };
            map.AddComponent(sniper);
            map.AddComponent(assault);
            map.AddComponent(support);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Singleton");
            Squad squad = new Squad();
            squad.Assing("Петров");
           
            Console.WriteLine("Командиром отряда назначен " + squad.Commandor.LastName);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Builder");

            Creator creator = new Creator();

            LocationBuilder builder = new MountainLocation();

            Location mountains = creator.Create(builder);
            Console.WriteLine(mountains.ToString());
            mountains.Title = "Горная локация";

            builder = new FlatLocation();
            Location flatlocation = creator.Create(builder);
            Console.WriteLine(flatlocation.ToString());
            flatlocation.Title = "Равнинная локация";
            map.AddComponent(mountains);
            map.AddComponent(flatlocation);


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Adapter");
            Tank tank = new Tank(50, 60);
            Driver driver = new Driver();
            driver.Control(tank);
            Plane plane = new Plane();
            IVehicle planeAdapter = new Adapter(plane);
            driver.Control(planeAdapter);
            driver.Title = "Водитель";
            map.AddComponent(driver);





            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Паттерн Decorator");
            Car truck = new Truck();
            truck = new CarWithoutEquipment(truck);
            Console.WriteLine(truck.Type);
            Console.WriteLine("Количество сидячих мест: "+ truck.SeatsAmount());
            truck.Title = "Машина";
            map.AddComponent(truck);
            var soldiers = map.Find("Поддержка");
            soldiers.Draw();

            




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
    class Commandor : IComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Title - {Title}");
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }

        private static Commandor instance;

        public string LastName { get; private set; }

        private Commandor(string lastname)
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
        class Assault : SoldierFactory, IComponent
        {
            public string Title { get; set; }
            public void Draw()
            {
                Console.WriteLine($"Title - {Title}");
            }
            public IComponent Find(string title)
            {
                return Title == title ? this : null;
            }
            public override Weapon CreateWeapon()
            {
                return new Rifle();
            }
            public override Utility CreateUtility()
            {
                return new ExplodeUtility();
            }
        }
        class Sniper : SoldierFactory, IComponent
        {
            public string Title { get; set; }
            public void Draw()
            {
                Console.WriteLine($"Title - {Title}");
            }
            public IComponent Find(string title)
            {
                return Title == title ? this : null;
            }
            public override Weapon CreateWeapon()
            {
                return new SniperRifle();
            }
            public override Utility CreateUtility()
            {
                return new HealUtility();
            }
        }
    class Support : SoldierFactory, IComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Title - {Title}");
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }

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
        class Location : IComponent
        {
            public string Title { get; set; }
            public void Draw()
            {
                Console.WriteLine($"Title - {Title}");
            }
            public IComponent Find(string title)
            {
                return Title == title ? this : null;
            }

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
                void Drive();
         }
        interface IPlane
        {
            void Fly();
        }
        class Plane: IPlane
        {
             public void Fly()
             {
                Console.WriteLine("Пересели на самолет, летим");
             }
        }
        class Driver : IComponent
        {
            public string Title { get; set; }
            public void Draw()
            {
                Console.WriteLine($"Title - {Title}");
            }
            public IComponent Find(string title)
            {
                return Title == title ? this : null;
            }
            public void Control(IVehicle vehicle)
            {
                vehicle.Drive();
            }
        }
        class Adapter: IVehicle
        {
            Plane plane;
            public Adapter(Plane p)
            {
                plane = p;
            }
            public void Drive()
            {
                plane.Fly();
            }

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
                public void Drive()
                {
                    Console.WriteLine("Едем на танке");
                }
        }
    abstract class Car : IComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine($"Title - {Title}");
        }
        public IComponent Find(string title)
        {
            return Title == title ? this : null;
        }
        public string Type { get; protected set; }
        public Car(string type)
        {
            this.Type = type;
        }
        public abstract int SeatsAmount();
         
    }
    class Truck : Car, IComponent
    {
        public Truck() : base("Грузовик")
        { }
        public override int SeatsAmount()
        {
            return 12;
        }
    }
    class Suv: Car
    {
        public Suv(): base("Внедорожник")
        { }
        public override int SeatsAmount()
        {
            return 6;
        }
    }
    abstract class CarDecorator: Car
    {
        protected Car car;
        public CarDecorator(string type, Car car): base(type)
        {
            this.car = car;
        }
    }
    class CarWithoutEquipment : CarDecorator
    {
        public CarWithoutEquipment(Car car): base(car.Type + " без снаряжения", car)
        { }
        public override int SeatsAmount()
        {
            return car.SeatsAmount() + 2;
        }
    }
    //------------------------------------------------------------------------------------------
    public interface IComponent 
    { 
        string Title { get; set; }
        void Draw();
        IComponent Find(string title);
    }
    public class MapComponent : IComponent
    {
        public string Title { get; set; }
        public void Draw()
        {
            Console.WriteLine(Title);
        }
        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            return null;
        }
    }
    public class Map : IComponent //композит
    {
        private readonly List<IComponent> map = new List<IComponent>();
        public string Title { get; set; }
        public void AddComponent(IComponent component)
        { 
            map.Add(component);
        }
        public void Draw()
        {
            Console.WriteLine(Title);
            foreach (var component in map)
            { 
                component.Draw();
            } 
        }
        public IComponent Find(string title)
        {
            if (Title == title)
            {
                return this;
            }
            foreach (var component in map)
            { 
                var found = component.Find(title);
                if (found != null)
                { 
                    return found;
                } 
            }
            return null;
        }
    }

}
