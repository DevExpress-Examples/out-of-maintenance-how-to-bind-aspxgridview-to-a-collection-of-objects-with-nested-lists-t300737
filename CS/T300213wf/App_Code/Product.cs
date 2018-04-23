using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Product
{
	public int Id { get; set; }
	public string Name { get; set; }
	public List<Store> Stores { get; set; }

	public Product() {
		Stores = new List<Store>();
	}
}
