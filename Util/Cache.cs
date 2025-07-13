using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Cache
    {
        private string FilePath { get; }
        private string SEP = "<?#?>";
        private Dictionary<string, string> Data = new Dictionary<string, string>();
        public Cache(string filePath)
        {
            this.FilePath = filePath;
        }
        public void Add(string key, string value)
        {
            if (Data.ContainsKey(key))
            {
                Data.Remove(key);
                Data.Add(key, value);
            }
            else
                Data.Add(key, value);
        }

        public void Load()
        {
            foreach (string line in File.ReadLines(FilePath))
            {
                string[] parts = line.Split(new string[] {SEP}, StringSplitOptions.None);
                Data.Add(parts[0], parts[1]);
            }
        }
        public string Get(string key)
        {
            Data.TryGetValue(key, out string value);
            return value;
        }

        public bool Save()
        {
            File.WriteAllText(FilePath, "");
            try
            {
                foreach(string key in Data.Keys)
                {
                    Data.TryGetValue(key, out string value);
                    if (value != null)
                    {
                        File.AppendAllText(FilePath, $"{key}{SEP}{value}\n");
                    }

                }
            } catch (Exception e) { return false; }
            return true;
        }


        public void Clear()
        {
            Data.Clear();
            Save();
        }


    }
}
