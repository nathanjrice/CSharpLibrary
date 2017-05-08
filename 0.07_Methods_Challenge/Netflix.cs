using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Methods_Challenge
{
    class Netflix
    {
            public string MovieName { get; set; }
            public string Genre { get; set; }
            public double Rating { get; set; }
            public int TotalMinutes { get; set; }


            public void NetflixMovieInfo()
            {
                Console.WriteLine("{0}, {1}, {2}", MovieName, Genre, Rating);

                if (this.Rating >= 4)
                {
                    //do stuff
                    Console.WriteLine("You should watch this!");
                }
                else
                {
                    //do something else
                    Console.WriteLine("You may not want to watch this");
                }

            }

            public string LastViewed(string user, string time)
            {
                string details = user + "watched this at " + time;
                Console.WriteLine(details);

                return details;
            }


            public int MinutesLeft(int minutesViewed)
            {
                int MinutesLeft = this.TotalMinutes - minutesViewed;
                Console.WriteLine("There are " + MinutesLeft + " minutes left in " + this.MovieName);
                return MinutesLeft;
            }
        }
}
