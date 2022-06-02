using AbstractFactory.Interface;

namespace AbstractFactory.Services;

public class ConcreteProductA1 : IAbstractProductA
{
	public string UseFulFunctionA()
	{
		return "The result of the product A1.";
	}
}