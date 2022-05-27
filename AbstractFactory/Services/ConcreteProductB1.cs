using AbstractFactory.Interface;

namespace AbstractFactory.Services;

public class ConcreteProductB1 : IAbstractProductB
{
	public string UsefulFunctionB()
	{
		return "The result of the product B1.";
	}
	public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
	{
		var result = collaborator.UseFulFunctionA();

		return $"The result of the B1 collaborating with the ({result})";
	}

	
}