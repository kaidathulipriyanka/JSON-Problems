using System.Xml;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;  

namespace JSON_Inventory
{
    class InventoryItem
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double PricePerKg { get; set; }

        public double CalculateValue()
        {
            return Weight * PricePerKg;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Read JSON data from a file
                string jsonFilePath = "C:\\Users\\HP\\OneDrive\\Desktop\\RFP(Remap)\\JSON Problems\\JSON Inventory\\inventory.json";
                string jsonData = File.ReadAllText(jsonFilePath);

                // Deserialize JSON data into a list of InventoryItems
                List<InventoryItem> inventory = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonData);

                // Calculate the value for each inventory item
                foreach (var item in inventory)
                {
                    double value = item.CalculateValue();
                    Console.WriteLine($"Item: {item.Name}, Weight: {item.Weight} kg, Price per kg: {item.PricePerKg:C}, Value: {value:C}");
                }

                // Serialize the updated inventory back to JSON
                string updatedJsonData = JsonConvert.SerializeObject(inventory, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText("updated_inventory.json", updatedJsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }
    }
}
