using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static Dictionary<string, string> dictionary;

        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>
            {
                { "alma", "apple" },
                { "fa", "tree" }
            };

            //add more words to your dictionary

            dic.Add("kutya", "dog");
            dic.Add("macska", "cat");

            AddWord(dic, "kacsa", "duck");
            RemoveWord("alma", dic);
            Console.WriteLine(TranslateToEnglish("kacsa", dic));

        }

        // Implement this method. It should add the given key-value pair to the the dictionary
        public static void AddWord(Dictionary<string, string> dict, string hungarianWord, string englishWord)
        {
            if (dict.ContainsKey(hungarianWord))
            {
                dict[hungarianWord] = englishWord;
            }
            else
            {
                dict.Add(hungarianWord, englishWord);
            }
        }

        // Implement this method. It should remove the key-value pair by the given key from the dictionary
        public static void RemoveWord(string hungarianWord, Dictionary<string, string> dictionary)
        {
            dictionary.Remove(hungarianWord);
        }

        // Implement a method which works as a translator from Hungarian to English
        // Example: you give it a parameter "fa" and it's output is "tree"
        public static string TranslateToEnglish(string hungarianWord, Dictionary<string, string> dictionary)
        {
            return (dictionary[hungarianWord]);
        }

        // Implement a method which works as a translator from English to Hungarian
        // Example: you give it a parameter "apple" and it's output is "alma"
        public static string TranslateToHungarian(string english)
        {

        }
    }
}