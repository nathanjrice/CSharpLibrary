using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Netflix IronFist = new Netflix();
            IronFist.MovieName = "Iron Fist";
            IronFist.Genre = "Action";
            IronFist.Rating = 2.5;
            IronFist.TotalMinutes = 52;
            IronFist.MinutesLeft(5);

            IronFist.NetflixMovieInfo();


            Netflix CivilWar = new Netflix();
            CivilWar.MovieName = "Captain America 3: Civil War";
            CivilWar.Genre = "Action";
            CivilWar.Rating = 4.5;


            CivilWar.NetflixMovieInfo();


            Netflix Strange = new Netflix();
            Strange.MovieName = "Stranger Things";
            Strange.Genre = "Mystery, Suspense, Horror";
            Strange.Rating = 5;

            Strange.NetflixMovieInfo();



            Console.ReadLine();

        }
    }
}
