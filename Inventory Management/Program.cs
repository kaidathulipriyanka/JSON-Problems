using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

 class InventoryItem
{
    public string Name { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }

    public int CalculateValue()
    {
        return Price * Quantity;
    }
}

 class InventoryManager
{
    private List<InventoryItem> inventory = new List<InventoryItem>();

    public void AddItem(InventoryItem item)
    {
        inventory.Add(item);
    }

    public int CalculateTotalValue()
    {
        int totalValue = 0;
        foreach (var item in inventory)
        {
            totalValue += item.CalculateValue();
        }
        return totalValue;
    }

    public string GetInventoryAsJson()
    {
        return JsonConvert.SerializeObject(inventory);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Read JSON input from a file 
        string jsonInput = File.ReadAllText("C:\\Users\\HP\\OneDrive\\Desktop\\RFP(Remap)\\JSON Problems\\Inventory Management\\InventoryJsonFile.json");

        // Deserialize JSON into a list of InventoryItem objects
        List<InventoryItem> items = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonInput);

        // Create an InventoryManager
        InventoryManager manager = new InventoryManager();

        // Add items to the manager
        foreach (var item in items)
        {
            manager.AddItem(item);
        }

        // Calculate the total value of the inventory
        int totalValue = manager.CalculateTotalValue();
        Console.WriteLine("Total Inventory Value: " + totalValue);

        // Get the inventory as JSON and output it
        string jsonOutput = manager.GetInventoryAsJson();
        Console.WriteLine("Inventory JSON:");
        Console.WriteLine(jsonOutput);
    }
}

