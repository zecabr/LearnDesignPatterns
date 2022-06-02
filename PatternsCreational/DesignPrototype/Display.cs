using Prototype.Model;

namespace Prototype;

public class Display
{
	public void DisplayValues(Person p)
	{
		Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}",
			p.Name, p.Age, p.BirthDate);
		Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
	}
}