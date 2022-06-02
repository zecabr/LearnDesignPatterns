namespace AbstractFactory.Interface;

public interface IAbstractFactory
{
	IAbstractProductA CreateProductA();
	IAbstractProductB CreateProductB();
}