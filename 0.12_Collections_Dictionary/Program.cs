using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_Collections_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();


            dictionary.Add("2000", "Gladiator");
            dictionary.Add("2001", "Beautiful Mind");
            dictionary.Add("2002", "Chicago");
            dictionary.Add("2003", "ROTK");
            dictionary.Add("2004", "Million Dollar Baby");
            dictionary.Add("2005", "Crash");

           /* foreach (KeyValuePair<string, string> pair in dictionary)
            {
                Console.WriteLine("In {0} the Oscar for Best Picture was awarded to {1}", pair.Key, pair.Value);
            }
            */

            Dictionary<string, string[]> bestPictureNoms = new Dictionary<string, string[]>();

            bestPictureNoms.Add("2000", new string[] { "Gladiator", "Chocolat", "CTHD", "Erin Brockovich", "Traffic" });
            bestPictureNoms.Add("2001", new string[] { "A Beautiful Mind", "Gosford Park", "In the Bedroom", "The Lord of the Rings: The Fellowship of the Ring", "Moulin Rouge!" });
            bestPictureNoms.Add("2002", new string[] { "Chicago", "Gangs of New York", "The Hours", "The Lord of the Rings: The Two Towers", "The Pianist" });
            bestPictureNoms.Add("2003", new string[] { "The Lord of the Rings: The Return of the King", "Lost in Translation", "Master and Commander: The Far Side of the World", "Mystic River", "Seabiscuit" });
            bestPictureNoms.Add("2004", new string[] { "Million Dollar Baby", "The Aviator", "Finding Neverland", "Ray", "Sideways" });
            bestPictureNoms.Add("2005", new string[] { "Crash", "Brokeback Mountain", "Capote", "Good Night, and Good Luck", "Munich" });

          /*  foreach (KeyValuePair<string, string[]> bestPictureNom in bestPictureNoms)
            {
                Console.WriteLine("{0}: {1}, {2}, {3}, {4}, {5}", bestPictureNom.Key, bestPictureNom.Value[0], bestPictureNom.Value[1], bestPictureNom.Value[2], bestPictureNom.Value[3], bestPictureNom.Value[4]);
            }
            */

            Console.WriteLine("Please type a year to show the movie that won;");
            string input1 = Console.ReadLine();

            if (dictionary.ContainsKey(input1))
            {
                string valueForKey = dictionary[input1];
                Console.WriteLine("The best picture in " + input1 + " was " + valueForKey);
            }


            Console.WriteLine("Please type the year to show the movies that were up for an award that year:");
            string input2 = Console.ReadLine();

            if (bestPictureNoms.ContainsKey(input2))
            {
                string[] valueForKey = bestPictureNoms[input2];
                string s = string.Join(", ", valueForKey);
                Console.WriteLine("The Best Picture nominees in " + input2 + " included " + s);
            }

            Console.ReadLine();

        }
    }
}
