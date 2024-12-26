
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.RubankoGV.Sprint7.V8.Lib
{
    public class DataService
{
    public List<string[]> LoadDataFromFile(string path)
    {
        
        string line = File.ReadAllText(path).Replace('\n', '\r');
        string[] lines = line.Split('\r', StringSplitOptions.RemoveEmptyEntries);
        List<string[]> strings = new List<string[]>();
        for (int i = 0; i < lines.Length; i++)
        {
            strings.Add(lines[i].Split(';'));

        }
        return strings;

        }
    }
}