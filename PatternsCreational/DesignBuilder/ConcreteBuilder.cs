using Builder.Interface;
using BuilderProject.Model;

namespace BuilderProject;

public class ConcreteBuilder : IBuilder
{
	private Product _product = new();

	// A fresh builder instance should contain a blank product object, which
	// is used in further assembly.
	public ConcreteBuilder()
	{
		Reset();
	}

	public void Reset()
	{
		_product = new Product();
	}
	public void BuildPartA()
	{
		_product.Add("PartA1");
	}

	public void BuildPartB()
	{
		_product.Add("PartB1");
	}

	public void BuildPartC()
	{
		_product.Add("PartC1");
	}
	public Product GetProduct()
	{
		var result = _product;

		Reset();

		return result;
	}
}