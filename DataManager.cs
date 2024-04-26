using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

public class DataManager
{
    private string _filePath;

    public DataManager(string filePath)
    {
        _filePath = filePath;
    }

    public List<Eleve> LoadData()
    {
        if (!File.Exists(_filePath))
            return new List<Eleve>();
        
        string jsonData = File.ReadAllText(_filePath);
        return JsonConvert.DeserializeObject<List<Eleve>>(jsonData) ?? new List<Eleve>();
    }

    public void SaveData(List<Eleve> eleves)
    {
        string jsonData = JsonConvert.SerializeObject(eleves, Formatting.Indented);
        File.WriteAllText(_filePath, jsonData);
    }
}

