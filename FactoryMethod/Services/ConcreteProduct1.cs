using FactoryMethod.Interface;

namespace FactoryMethod.Services;

class ConcreteProduct1 : IProduct
{
	public string Operation()
	{
		return "{Result of ConcreteProduct1}";
	}
}
