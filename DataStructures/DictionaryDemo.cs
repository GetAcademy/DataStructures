using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class DictionaryDemo
    {
        public static void Run()
        {
            /*
             * Lage eksmpel på bruk av Dictionary
             * Prøve på en egen enkel implementasjon av Dictionary
             * Se kort på den reelle kildekoden bak Dictionary
             */

            var gen = new RandomNameGenerator();
            var names = gen.GetNames().Take(1000);

            var words = new Dictionary<string, string>();
            //var words = names.ToDictionary(name => name.Substring(0, 2));
            //var words = names.ToDictionary(name => name.Substring(0, 2), 
            //                                       name => name.Substring(2));
            foreach (var name in names)
            {
                var start = name.Substring(0, 2);
                if (!words.ContainsKey(start))
                    words.Add(start, name);
            }

            foreach (var name in gen.GetNames().Take(10))
            {
                var end = name.Substring(name.Length - 2);
                if(words.ContainsKey(end))
                    Console.WriteLine(name + " " + words[end]);
            }
            
            //foreach (var key in words.Keys)
            //{
            //    Console.WriteLine($"Nøkkel: {key} -> Verdi: {words[key]}");
            //}


            //for (var key = 0; key < counts.Length; key++)
            //{
            //    var value = counts[key];
            //    Console.WriteLine($"Antall ord med lengde {key} er {value}");
            //}
        }
    }
}
