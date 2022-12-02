using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class WriteData : MonoBehaviour
{
    private string path;
    //private FileStream fs;
    // Start is called before the first frame update
    void Start()
    {
        //create file
        path = "./Data/PlayerData.csv";
        //fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        if (!File.Exists(path))
        {
            using(FileStream fs = File.Create(path))
            {
                AddText(fs, "Username,Password,Water Score,Energy Score,Deforestation Score");
            }
        }
        WriteMyData("MyUser",  "32", "57", "100");
        WriteMyData("AnotherUser", "32", "57", "100");
        WriteMyData("lfg", "40", "100", "100");
        GetPlayerData("MyUser");
        GetPlayerData("nonexistentuser");


    }

    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }

    public void WriteMyData(string username, string password, string water = "0", string energy = "0", string deforest = "0")
    {
        bool found = false;
        List<string> allLines = new List<string>();
        using(FileStream fs = File.OpenRead(path))
        {
            using (var sr = new StreamReader(fs))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    var components = line.Split(',');
                    if(components[0] == username)
                    {
                        found = true;
                        if (water != "0" && Int32.Parse(water) > Int32.Parse(components[2]))
                        {
                            components[2] = water;
                        }
                        if (energy != "0" && Int32.Parse(energy) > Int32.Parse(components[3]))
                        {
                            components[3] = energy;
                        }
                        if (deforest != "0" && Int32.Parse(deforest) > Int32.Parse(components[4]))
                        {
                            components[4] = deforest;
                        }
                        line = String.Join(',', components);
                    }
                    allLines.Add(line);
                    Debug.Log(line);
                }
                if (!found)
                {
                    allLines.Add(username + "," + password + "," + water + "," + energy + "," + deforest);
                }
            }
        }
        File.WriteAllLines(path, allLines);


    }

    public string[] GetPlayerData(string username)
    {
        using (FileStream fs = File.OpenRead(path))
        {
            using (var sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] components = line.Split(',');
                    if (components[0] == username)
                    {
                        Debug.Log("Found " + username);
                        return components;
                    }
                }
            }
        }
        Debug.Log("user not found");
        return new string[0];
    }


    public List<string[]> GetAllData()
    {
        List<string[]> alldata;
        using (FileStream fs = File.OpenRead(path))
        {
            using (var sr = new StreamReader(fs))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    alldata.Add(line.Split(','));
                }
            }
        }
        return alldata;
    }
}
