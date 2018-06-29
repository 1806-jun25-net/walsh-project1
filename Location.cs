using System;
using System.Collections;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location : Address
{
	private List<List<string>> OrderHistory { get; set; }
	private Dictionary<string, int> Inventory { get; set; }
	private Address { get; set; }
    
	
	public bool CheckInventory(Order order);
    public void UseInventory(Order order); 
	
}
