using Prototype.Interfaces;

namespace Prototype.Entity;

public class Person: ICloneable, IMyCloneable<Person>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;        
    }

    public override string ToString()
        => $"Id: {Id}, FirstName: {FirstName}, LastName: {LastName}";

    public virtual object Clone() => MemberwiseClone();

    public Person CloneObj()
    {
        return new Person(Id, FirstName, LastName);
    }   
}
