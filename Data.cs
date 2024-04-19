using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EcoTrack_Project
{
    public static class DataStorage
    {
        private static string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "activities.json");

        public static async Task SaveActivitiesAsync(List<Activity> activities)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(activities, options);
            await File.WriteAllTextAsync(filePath, jsonString);
        }

        public static async Task<List<Activity>> LoadActivitiesAsync()
        {
            if (File.Exists(filePath))
            {
                string jsonString = await File.ReadAllTextAsync(filePath);
                return JsonSerializer.Deserialize<List<Activity>>(jsonString);
            }
            return new List<Activity>();
        }
    }
}
