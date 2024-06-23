using Prototype.Entity;

namespace Prototype;

public static class Tests
{
    public static void Run()
    {
        ShallowCloneCustom();
        ShallowClone();

        DeepCloneCustom();
        DeepClone();
    }

    private static void ShallowCloneCustom()
    {
        Console.WriteLine("Поверхностное клонирование через интерфейс IMyCloneable");
                
        var pilot = new Pilot(1, "Балу", "Вираж", "Аэрофлот", true);      
        Console.WriteLine(pilot.ToString());
               
        var pilotCloned = pilot.CloneObj();     
       
        if (pilot.Equals(pilotCloned))
        {
            Console.Write("Объекты имеют одинаковые значения. ");
        }

        if (!object.ReferenceEquals(pilot, pilotCloned))
        {
            Console.WriteLine("Но это разные объекты.");
        }

        Console.WriteLine(string.Empty);
    }

    private static void ShallowClone()
    {
        Console.WriteLine("Поверхностное клонирование через ICloneable");

        var pilot = new Pilot(2, "Кит", "Чудиков", "Победа", false);
        Console.WriteLine(pilot.ToString());

        var pilotCloned = pilot.Clone() as Pilot;

        if (pilot.Equals(pilotCloned))
        {
            Console.Write("Объекты имеют одинаковые значения. ");
        }

        if (!object.ReferenceEquals(pilot, pilotCloned))
        {
            Console.WriteLine("Но это разные объекты.");
        }

        Console.WriteLine(string.Empty);
    }

    private static void DeepCloneCustom()
    {
        Console.WriteLine("Глубокое клонирование через интерфейс IMyCloneable");

        var passenger = new Passenger(1, "Василий", "Рогов", true);
        passenger.ListOfServices.Add("шампанское");
        passenger.ListOfServices.Add("планшет с фильмами и музыкой");
        passenger.ListOfServices.Add("меню разработанное именитым шеф-поваром.");

        Console.WriteLine(passenger.ToString());

        var passengerCloned = passenger.CloneObj();

        if (passenger.Equals(passengerCloned))
        {
            Console.Write("Объекты имеют одинаковые значения. ");
        }

        if (!object.ReferenceEquals(passenger, passengerCloned))
        {
            Console.WriteLine("Но это разные объекты.");
        }

        Console.WriteLine(string.Empty);
    }

    private static void DeepClone() 
    {
        Console.WriteLine("Глубокое клонирование через ICloneable");

        var passenger = new Passenger(2, "Анастасия", "Иванова", true);
        passenger.ListOfServices.Add("питание");

        Console.WriteLine(passenger.ToString());

        var passengerCloned = passenger.Clone() as Passenger;

        if (passenger.Equals(passengerCloned))
        {
            Console.Write("Объекты имеют одинаковые значения. ");
        }

        if (!object.ReferenceEquals(passenger, passengerCloned))
        {
            Console.WriteLine("Но это разные объекты.");
        }

        Console.WriteLine(string.Empty);
    }
}
