using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AndroidApkSignHelper
{
    internal class IniFileHelper
    {
        public static Dictionary<string, Dictionary<string, string>> ReadIniFile(string path)
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate)))
            {
                string? line = reader.ReadLine();
                string? section = null;
                while (line != null) 
                {
                    if (line.StartsWith("[") &&  line.EndsWith("]"))
                    {
                        section = line.Substring(1, line.Length - 2);
                        result.Add(section, new Dictionary<string, string>());
                    }

                    if (line.Contains("="))
                    {
                        string[] items = line.Split("=");
                        if (null != section)
                        {
                            result[section].Add(items[0], items[1]);
                        }
                    }

                    line = reader.ReadLine();
                }
                reader.Close();
            }

            return result;
        }

        public static string? ReadIniFileValue(string path, string section, string key) {
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.OpenOrCreate)))
            {
                string? line = reader.ReadLine();
                string? currentSection = null;
                while (line != null)
                {
                    if (line.StartsWith("[") && line.EndsWith("]"))
                    {
                        currentSection = line.Substring(1, line.Length - 2);
                    }

                    if (line.Contains("="))
                    {
                        string[] items = line.Split("=");
                        if (null != currentSection && currentSection.Equals(section) && items[0].Equals(key))
                        {
                            return items[1];
                        }
                    }

                    line = reader.ReadLine();
                }
                reader.Close();
            }
            return null;
        }

        public static void WriteIniFile(string path, string section, string key, string value)
        {
            Dictionary<string, Dictionary<string, string>> allIniFileContent = ReadIniFile(path);
            if (null != allIniFileContent)
            {
                if (allIniFileContent.ContainsKey(section))
                {
                    Dictionary<string, string> sectionContent = allIniFileContent[section];
                    if (sectionContent.ContainsKey(key))
                    {
                        sectionContent[key] = value;
                    }
                    else
                    {
                        sectionContent.Add(key, value);
                    }
                } 
                else
                {
                    Dictionary<string, string> sectionContent = new Dictionary<string, string>();
                    sectionContent.Add(key, value);
                    allIniFileContent.Add(section, sectionContent);
                }
            }

            if (null != allIniFileContent)
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string sectionKey in allIniFileContent.Keys)
                    {
                        sw.WriteLine("[" + sectionKey + "]");
                        Dictionary<string, string> items = allIniFileContent[sectionKey];
                        foreach(string iKey in items.Keys)
                        {
                            sw.WriteLine(iKey + "=" + items[iKey]);
                        }                        
                    }
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}
