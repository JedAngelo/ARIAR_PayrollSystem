using Newtonsoft.Json;
using System.IO;

namespace PayrollSystem.Helpers
{
    public class AppApiUri
    {
        public string Uri { get; set; }
    }

    public static class UriHelper
    {
        private static readonly string FilePath = "AppApiUri.json";

        public static AppApiUri LoadUri()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                // Deserialize the JSON using Newtonsoft.Json
                return JsonConvert.DeserializeObject<AppApiUri>(json) ?? new AppApiUri();
            }

            return new AppApiUri { Uri = "http://localhost:2410" };
        }
        public static void SaveUri(AppApiUri settings)
        {
            // Serialize the AppApiUri object to JSON
            var settingsJson = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(FilePath, settingsJson);
        }
    }
}
