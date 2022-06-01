using FactoryMethod.Interface;
using FactoryMethod.Model;

namespace FactoryMethod.Services;

class ConcreteCreator2 : Creator
{
	public override IProduct FactoryMethod()
	{
		return new ConcreteProduct2();
	}
}
