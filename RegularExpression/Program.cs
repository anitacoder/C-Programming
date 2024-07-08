using System;
using System.Text.RegularExpressions;

namespace RegularExpressions {
    public class RegexExample {
        private static void showMatch(string text, string expr) {
            Console.WriteLine("The expression is: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach(Match match in mc) {
                Console.WriteLine("Found match: " + match.Value);
            }
        }

        public static void Main(string[] args) {
            string str = "Make Maize and Manage to Measure it";
            Console.WriteLine("Matching words that start with 'e'");
            showMatch(str, @"\be\w*");

            string str1 = "Have you ever climbed the mount everest ?";
            Console.WriteLine("Matching words that start with 'ever'");
            showMatch(str1, @"\bever\w*");

            string str2 = "The chimp is a champ in the jungle";
            Console.WriteLine("Matching words that start with 'ch'");
            showMatch(str2, @"\bch\w*");

            string str3 = "I run to stay fit, run a business, run out of time and love to watch the sun run in the sky";
            Console.WriteLine("Matching words that start with 'run'");
            showMatch(str3, @"\brun\w*");
        }
    }
}
