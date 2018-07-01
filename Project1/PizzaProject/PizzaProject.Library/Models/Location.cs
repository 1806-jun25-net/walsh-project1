using System;
using System.Collections;
using System.Collections.Generic;

// class Location holds a pizza chain location
// with order history and inventory. Rejects order
// if inventory is not sufficient. Decrements inventory
// when orders are accepted. 
public class Location 
{
	private List<List<string>> OrderHistory { get; set; }
	private Dictionary<string, int> Inventory { get; set; }
	
    
	// class methods
	/*
     public bool CheckInventory(Order order);
     public void UseInventory(Order order); 
	*/
}
