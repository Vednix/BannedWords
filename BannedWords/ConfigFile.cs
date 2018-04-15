using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace BannedWords
{
    public class ConfigFile
    {
        public char CensorChar = '*';
        public List<string> BannedWords = new List<string>();

        public static ConfigFile Read(string path)
        {
            if (!File.Exists(path))
            {
                ConfigFile config = new ConfigFile();

                config.BannedWords.Add("noob");
                config.BannedWords.Add("idiot");
                config.BannedWords.Add("fuck");
                config.BannedWords.Add("shit");
                config.BannedWords.Add("cc");
                config.BannedWords.Add("cl");
                config.BannedWords.Add("dit");
                config.BannedWords.Add("dit me may");
                config.BannedWords.Add("asshole");
                config.BannedWords.Add("cunt");
                config.BannedWords.Add("fuck");
                config.BannedWords.Add("con cac");
                config.BannedWords.Add("du ma");
                config.BannedWords.Add("ditme");
                config.BannedWords.Add("dit con me may");

                File.WriteAllText(path, JsonConvert.SerializeObject(config, Formatting.Indented));
                return config;
            }

            return JsonConvert.DeserializeObject<ConfigFile>(File.ReadAllText(path));
        }
    }
}