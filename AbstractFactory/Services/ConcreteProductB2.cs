using AbstractFactory.Interface;

namespace AbstractFactory.Services;

public class ConcreteProductB2 : IAbstractProductB
{
	public string UsefulFunctionB()
	{
		return "The result of the product B2.";
	}
	public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
	{
		var result = collaborator.UseFulFunctionA();
		return $"The result of the B2 collaborating with the ({result})";
	}

	
}