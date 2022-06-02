﻿namespace BuilderProject.Model;

public class Product
{
	private readonly List<object> _parts = new();

	public void Add(string part)
	{
		_parts.Add(part);
	}
    public string ListParts()
    {
        string str = string.Empty;

        for (int i = 0; i < _parts.Count; i++)
        {
            str += _parts[i] + ", ";
        }

        str = str.Remove(str.Length - 2); 

        return "Product parts: " + str + "\n";
    }
}