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
            
            ConfigFile configFile = new ConfigFile("../../config/Game.ini");
            //Console.WriteLine(configFile.SettingGroups["street19"].Settings["name"].GetValueAsString());
            foreach (KeyValuePair<string, SettingsGroup> group in configFile.SettingGroups)
            {
                Console.WriteLine("****************************");
                Console.WriteLine(group.Key + ":");
                Console.WriteLine();

                foreach (KeyValuePair<string, Setting> value in group.Value.Settings)
                {
                    Console.WriteLine("{0} = {1} (Is Array? {2})", value.Key, value.Value.GetValueAsString(), value.Value.IsArray);
                    ConfigFile configFile2 = new ConfigFile("../../config/" + value.Value.GetValueAsString());
                    foreach (KeyValuePair<string, SettingsGroup> group2 in configFile2.SettingGroups)
                    {
                        Console.WriteLine("****************************");
                        Console.WriteLine(group2.Key + ":");
                        Console.WriteLine();

                        foreach (KeyValuePair<string, Setting> value2 in group2.Value.Settings)
                            Console.WriteLine("{0} = {1} (Is Array? {2})", value2.Key, value2.Value.RawValue, value2.Value.IsArray);

                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
