using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class saving
{
    public static void savePosOfCam(testSaving player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        //string path = Application.persistentDataPath + "/player.save";
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        posSave data = new posSave(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static posSave loadPos()
    {
        string path = Application.persistentDataPath + "/player.save";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            posSave data = formatter.Deserialize(stream) as posSave;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save File Not Found in " + path);
            return null;
        }
    }
}