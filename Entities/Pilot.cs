using Prototype.Interfaces;

namespace Prototype.Entity;

sealed class Pilot: Person, IMyCloneable<Pilot>, IEquatable<Pilot>
{
    public bool IsCaptain { get; set; }
    public string AirlineName { get; set; }

    public Pilot(int id, string firstName, string lastName,
        string airlineName, bool isCaptain) : base(id, firstName, lastName)
    {      
        AirlineName = airlineName;
        IsCaptain = isCaptain;
    }

    public override string ToString()
       => $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}, AirlineName: {AirlineName}, IsCaptain: {IsCaptain}";

    public new Pilot CloneObj()
    {
        return new Pilot(Id, FirstName, LastName, AirlineName, IsCaptain);
    }

    public override object Clone()
    {
        var pilot = base.Clone() as Pilot;

        pilot.Id = Id;
        pilot.FirstName = FirstName;
        pilot.LastName = LastName;       
        pilot.AirlineName = AirlineName;
        pilot.IsCaptain = IsCaptain;

        return pilot;
    }

    public bool Equals(Pilot obj)
    {
        return obj != null &&
               Id == obj.Id &&
               FirstName == obj.FirstName &&
               LastName == obj.LastName &&            
               AirlineName == obj.AirlineName &&
               IsCaptain == obj.IsCaptain;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Pilot);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode() ^
               AirlineName.GetHashCode() ^ IsCaptain.GetHashCode();
    }
}