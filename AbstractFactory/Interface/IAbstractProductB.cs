namespace AbstractFactory.Interface;

public interface IAbstractProductB
{
	string UsefulFunctionB();
	string AnotherUsefulFunctionB(IAbstractProductA collaborator);

}
