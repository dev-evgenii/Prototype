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
        return new Passenger(Id, FirstName, LastName, IsBusinessClass);
    }

    public override object Clone()
    {
        var passenger = base.Clone() as Passenger;

        passenger.Id = Id;
        passenger.FirstName = FirstName;
        passenger.LastName = LastName;
        passenger.IsBusinessClass = IsBusinessClass;

        return passenger;
    }

    public bool Equals(Passenger obj)
    {
        return obj != null &&
               Id == obj.Id &&
               FirstName == obj.FirstName &&
               LastName == obj.LastName &&
               IsBusinessClass == obj.IsBusinessClass;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Passenger);
    }

    public override int GetHashCode()
    {
       return Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode() ^ IsBusinessClass.GetHashCode();
    }
}
