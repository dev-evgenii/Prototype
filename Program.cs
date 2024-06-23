
/*
Описание: Есть 3 класса Person, Pilot, Passenger. Эти классы реализуют наследование. 
Базовый класс Person содержит поля Id, FirstName, LastName. От этого класса наследуются классы Pilot и Passenger.
Каждый класс реализуют интерфейс IClonable для клонирования и обобщеный интерфейс IMyClonable<T>.
*/

using Prototype;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Отус. ДЗ: паттерн прототип.");
Console.WriteLine(string.Empty);

Tests.Run();