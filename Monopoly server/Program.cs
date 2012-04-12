using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EasyConfig;
namespace Monopoly_server
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigFile configFile = new ConfigFile("map.ini");
            Console.WriteLine(configFile.SettingGroups["street19"].Settings["name"].GetValueAsString());
            foreach (KeyValuePair<string, SettingsGroup> group in configFile.SettingGroups)
            {
                Console.WriteLine("****************************");
                Console.WriteLine(group.Key + ":");
                Console.WriteLine();

                foreach (KeyValuePair<string, Setting> value in group.Value.Settings)
                    Console.WriteLine("{0} = {1} (Is Array? {2})", value.Key, value.Value.RawValue, value.Value.IsArray);

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
