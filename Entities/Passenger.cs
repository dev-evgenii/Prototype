using Prototype.Interfaces;

namespace Prototype.Entity;

sealed class Passenger : Person, IMyCloneable<Passenger>, IEquatable<Passenger>
{
    public bool IsBusinessClass { get; set; }
    public List<string> ListOfServices { get; set; }

    public Passenger(int id, string firstName, string lastName, 
        bool isBusinessClass) : base(id, firstName, lastName)
    {
        IsBusinessClass = isBusinessClass;     
        ListOfServices = new List<string>();
    }

    public override string ToString()
    {
        return $"{base.ToString()},[Услуги включенные в стоимость перелета: {string.Join(',', ListOfServices)}]";
    }  

    public new Passenger CloneObj()
    {
        var passenger = new Passenger(Id, FirstName, LastName, IsBusinessClass);
        if (ListOfServices != null)
        {
            passenger.ListOfServices = ListOfServices;
        }

        return passenger;
    }
    
    public override object Clone()
    {
        var passenger = base.Clone() as Passenger;

        passenger.Id = Id;
        passenger.FirstName = FirstName;
        passenger.LastName = LastName;
        passenger.IsBusinessClass = IsBusinessClass;

        if (ListOfServices != null)
        {
            passenger.ListOfServices = ListOfServices;
        }

        return passenger;
    }

    public bool Equals(Passenger obj)
    {
        return obj is Passenger passenger &&
               Id == passenger.Id &&
               FirstName == passenger.FirstName &&
               LastName == passenger.LastName &&
               IsBusinessClass == passenger.IsBusinessClass &&
               ListOfServices.SequenceEqual(passenger.ListOfServices);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(GetHashCode(), ListOfServices.GetHashCode());
    }
}
