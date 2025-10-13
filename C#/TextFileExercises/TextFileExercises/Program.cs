using System.Diagnostics;
using System.Text;
using System.IO;

void Sentencer(string filePath)
{

    Console.WriteLine("Enter sentences to add to the file (press Enter on an empty line to finish):");
    StringBuilder sb = new StringBuilder();
    string UserInput = "Input";
    while (UserInput != "")
    {
        sb.AppendLine(UserInput);
    }
    File.AppendAllText(filePath, sb.ToString());
}

// Sentencer("example.txt");

string[] lines = File.ReadAllLines("station.txt");

string stationwithstation(string[] lines){

        for (int i = 0; i < lines.Length; i++){

        string name = lines[i].Split(',')[0].Trim();
            
            if (name.ToLower().Contains("station")){

                return name;
            }
        }
        return "";
    }

Debug.Assert(stationwithstation(lines) == "Battersea Power Station");

List<string> stationnoshareletters(string[] lines, string word)
{
    List<string> none = new List<string>();
    string lowered = word.ToLower();
    for (int i = 0; i < lines.Length; i++)
    {
        string station = lines[i].Split(',')[0].Trim();
        string lowerstation = station.ToLower();
        bool sharesletter = false;

        for (int j = 0; j < lowerstation.Length; j++)
        {
            if (lowered.Contains(lowerstation[j]))
            {
                sharesletter = true;
                break;
            }
        }
        if (sharesletter == false)
        {
            none.Add(station);
        }
    }
    return none;
}

List<string> bothwords(string[] lines)
{
    List<string> both = new List<string>();
    for (int i = 0; i < lines.Length; i++)
    {
        string station = lines[i].Split(',')[0].Trim().ToLower();
        string[] parts = station.Split(' ');
        if (parts.Length == 2)
        {
            char l1 = parts[0][0];
            char l2 = parts[1][0];
            if (l1 == l2)
            {
                both.Add(station);
            }
        }
    }
    return both;
}

string longestline(string[] lines)
{
    List<string> lineNames = new List<string>();
    for (int i = 0; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(',');
        for (int j = 1; j < lines.Length; j++)
        {
            string lineName = parts[j].Trim();
            if (!lineNames.Contains(lineName))
            {
                lineNames.Add(lineName);
            }
        }
    }
    int[] cnt = new int[lineNames.Count];
    for (int i = 0; i < lines.Length; i++)
    {
        string[] parts = lines[i].Split(',');
        for (int j = 1; j < parts.Length; j++)
        {
            string lineName = parts[j].Trim();
            for (int k = 0; k < lineNames.Count; k++)
            {
                if (lineNames[k] == lineName)
                {
                    cnt[k]++;
                }
            }
        }
    }
    int max = 0;
    string longest = "";
    for (int i = 0; i < lineNames.Count; i++)
    {
        if (cnt[i] > max)
        {
            max = cnt[i];
            longest = lineNames[i];
        }
    }
    return longest;
}