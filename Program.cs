using System;
using System.Collections.Generic;

namespace dictionaries {
    class Program {
        static void Main (string[] args) {
            // Dictionary of Words
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string> () { { "hello", "used to introduce oneself to conversation" }, { "goodbye", "used to exit oneself from conversation" }
            };

            wordsAndDefinitions.Add ("awesome", "the feeling of students when they are learning C#");
            wordsAndDefinitions.Add ("yes", "to agree upon something");
            wordsAndDefinitions.Add ("no", "to disagree upon something");

            Console.WriteLine (wordsAndDefinitions["awesome"]);
            Console.WriteLine (wordsAndDefinitions["no"]);

            foreach (KeyValuePair<string, string> pair in wordsAndDefinitions) {
                Console.WriteLine ($"The definition of {pair.Key} is {pair.Value}.");
            }

            // List of Dictionaries about Words
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>> ();

            Dictionary<string, string> excitedWord = new Dictionary<string, string> ();

            excitedWord.Add ("word", "excited");
            excitedWord.Add ("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excitedWord.Add ("part of speech", "adjective");
            excitedWord.Add ("example sentence", "I am excited to leave at 4 PM!");

            dictionaryOfWords.Add (excitedWord);

            Dictionary<string, string> sadWord = new Dictionary<string, string> ();

            sadWord.Add ("word", "sad");
            sadWord.Add ("definition", "what I feel when I am having a bad day");
            sadWord.Add ("part of speech", "adjective");
            sadWord.Add ("example sentence", "Waking up before 10 AM makes me sad.");

            dictionaryOfWords.Add (sadWord);

            foreach (Dictionary<string, string> word in dictionaryOfWords) {
                foreach (KeyValuePair<string, string> pair in word) {
                    Console.WriteLine ($"{pair.Key}: {pair.Value}");
                }
            }
        }
    }
}