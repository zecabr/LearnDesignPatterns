using FactoryMethod.Interface;

namespace FactoryMethod.Services;

class ConcreteProduct2 : IProduct
{
	public string Operation()
	{
		return "{Result of ConcreteProduct2}";
	}
}