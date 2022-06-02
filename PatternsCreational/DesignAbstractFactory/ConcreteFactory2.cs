﻿using AbstractFactory.Interface;
using AbstractFactory.Services;

namespace AbstractFactory;

internal class ConcreteFactory2 : IAbstractFactory
{
	public IAbstractProductA CreateProductA()
	{
		return new ConcreteProductA2();
	}

	public IAbstractProductB CreateProductB()
	{
		return new ConcreteProductB2();
	}
}