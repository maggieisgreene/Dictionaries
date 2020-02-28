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

            // English Idioms
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>> ();

            idioms.Add ("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add ("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add ("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add ("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add ("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add ("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add ("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add ("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add ("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add ("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

            foreach (KeyValuePair<string, List<string>> idiom in idioms) {
                Console.WriteLine ($"{idiom.Key}: {String.Join (" ", idiom.Value)}");
            }
        }
    }
}