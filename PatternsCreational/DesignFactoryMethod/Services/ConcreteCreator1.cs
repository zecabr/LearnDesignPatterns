using FactoryMethod.Interface;
using FactoryMethod.Model;

namespace FactoryMethod.Services;

class ConcreteCreator1 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct1();
    }
}