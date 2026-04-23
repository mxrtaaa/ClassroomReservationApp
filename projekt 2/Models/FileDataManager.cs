using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClassroomReservationApp.Models
{
    public class FileDataManager
    {
        public void Save(AppData dataToSave, string filePath)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                ReferenceHandler = ReferenceHandler.Preserve
            };

            string jsonString = JsonSerializer.Serialize(dataToSave, options);
            File.WriteAllText(filePath, jsonString);
        }

        public AppData Load(string filePath)
        {
            if (!File.Exists(filePath))
            {
                return null;
            }

            string jsonString = File.ReadAllText(filePath);
            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.Preserve
            };

            return JsonSerializer.Deserialize<AppData>(jsonString, options);
        }
    }
}
