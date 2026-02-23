using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using FlexibleInventorySystem.Models;

namespace FlexibleInventorySystem.Utilities
{
    /// <summary>
    /// Handles file operations for inventory persistence
    /// </summary>
    public static class FileHandler
    {
        private static readonly string FilePath = "inventory.json";

        private static readonly JsonSerializerOptions _options =
            new JsonSerializerOptions
            {
                WriteIndented = true,
                PropertyNameCaseInsensitive = true
            };

        // ================= SAVE =================

        public static void SaveToFile(List<Product> products)
        {
            try
            {
                string json = JsonSerializer.Serialize(products, _options);
                File.WriteAllText(FilePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving inventory data.", ex);
            }
        }

        // ================= LOAD =================

        public static List<Product> LoadFromFile()
        {
            try
            {
                if (!File.Exists(FilePath))
                    return new List<Product>();

                string json = File.ReadAllText(FilePath);

                var products = JsonSerializer.Deserialize<List<Product>>(json, _options);

                return products ?? new List<Product>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading inventory data.", ex);
            }
        }
    }
}
