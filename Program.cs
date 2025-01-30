using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() 
            {
                "Old School Runescape",
                "Red Dead Redemption 2",
                "The Elder Scrolls Online",
                "Super Mario",
            };

            var orderedGameByLength = videoGames.OrderBy(x => x.Length).ToList();

            Console.WriteLine("List of video games ordered by length of name:");
            foreach (var game in orderedGameByLength)
            {
                Console.WriteLine($"- {game}");
            }
        }
    }
}
