using System.IO;
using UnityEngine;

public class FileReaderManager
{
    private const string path = "Assets/Resources/SaveState.txt";

    public void WriteIntoFile(int coins, int shorts, int stage)
    {
        StreamWriter writer = new StreamWriter(path, false);
        
        writer.WriteLine($"Stage={stage}");
        writer.WriteLine($"Short={shorts}");
        writer.WriteLine($"Modenas={coins}");
        
        writer.Close();
    }

    public void ReadFile()
    {
        StreamReader reader = new StreamReader(path);

        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();

            if (line != null && line.ToLower().Contains("short"))
            {
                // 0 Amarillo, 1 Rojo, 2 Azul, 3 Verde
                string[] parts = line.Split('=');
                
                int shorts = 0;
                int.TryParse(parts[^1], out shorts);

                GameManager.sharedInstance.PowerMultiplayer = shorts;
            }
        }
        
        reader.Close();
        
    }
}
