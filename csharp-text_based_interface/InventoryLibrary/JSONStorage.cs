using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        public Dictionary<string, object> objects = new Dictionary<string, object>();

        public void New(object obj)
        {
            try
            {
                objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
            }
            catch (Exception)
            {
                Console.WriteLine("Please Class Instance that inherit fron BaseClass needed");
            }
        }

        public Dictionary<string, object> All()
        {
            return objects;
        }

        public void Save()
        {
            var options = new sonSerializerOptions
            {
                writeIndented = true;
            }

            string fileName = "../../../../storage/inventory_manager.json";
            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            string fileName = "../../../../storage/inventory_manager.json";
            string jsonString = File.ReadAllText(fileName);
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        }
    }
}
