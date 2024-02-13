using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    public class RandomNameGenerator
    {
        private readonly char[] _consonants = { 'b', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v' };
        private readonly char[] _vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'æ', 'ø', 'å' };
        private readonly bool[][] _patterns = {
            new []{false, true, false, true},
            new []{false, true, false, false, true},
            new []{true, false, true, false, true},
        };
        private readonly Random _random;

        public RandomNameGenerator()
        {
            _random = new Random();
        }

        public IEnumerable<string> GetNames()
        {
            while (true)
            {
                var name = GetName();
                //Console.WriteLine("Log: Lagde " + name);
                yield return name;
            }
        }

        private string GetName()
        {
            var index = _random.Next(0, _patterns.Length - 1);
            return GetName(_patterns[index]);
        }

        private string GetName(bool[] pattern)
        {
            return new string(pattern.Select(GetCharacter).ToArray());
        }

        private char GetCharacter(bool isVowel)
        {
            return isVowel
                ? _vowels[_random.Next(0, _vowels.Length - 1)]
                : _consonants[_random.Next(0, _consonants.Length - 1)];
        }
    }
}
