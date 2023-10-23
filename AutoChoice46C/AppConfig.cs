using Newtonsoft.Json;
using System.IO;

public class AppConfig
{
    public bool FirstRun { get; set; }

    public static AppConfig Load(string filePath)
    {
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<AppConfig>(json);
        }

        return new AppConfig();
    }

    public void Save(string filePath)
    {
        string json = JsonConvert.SerializeObject(this);
        File.WriteAllText(filePath, json);
    }
}