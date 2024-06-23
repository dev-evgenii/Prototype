namespace Prototype.Interfaces;

public interface IMyCloneable<out T> where T : class
{
    T CloneObj();
}
