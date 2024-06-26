using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class SaveLoadData : MonoBehaviour
{
    //My attempt to connect the buttons to a saving/loading script to save an instance of a scene. For somre reason, it says the json library is unnecessary, but when using json
    //syntax, it doesn't exist. Maybe it was declared incorrectly. 
    public void Initialized()
    {
        jsonSettings.Formatting = Formatting.Indented;
    }

    public void Save<T>(T objectToSave, string destination)
    {
        string jsonString = JsonConvert.SerializeObject(onjectToSave, jsonSettings);
        File.WriteAllText(destination, jsonString);
    }

    public T Load<T>(string destination)
    {
        string jsonString = File.ReadAllText(destination);
        var objectToLoad = JsonConvert.DeserializeObject<T>(jsonString);
        return objectToLoad;
    }
}
