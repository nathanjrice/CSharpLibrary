using System;

namespace _0._03_Strings_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string message = string.Format("What it do youngin?");
            Console.WriteLine(message);

            string myString = string.Format("{0:C}", 123.45);
            Console.WriteLine(myString);

            string bString = string.Format("{0:P}", .123);
            Console.WriteLine(bString);

            string phoneString = string.Format("My phone number is: {0: (###)-###-####}", 1234567890);
            Console.WriteLine(phoneString);

            string instructor = "Paul";
            string instructor2 = "Kenn";
            string confusedItemOne = "walking";
            string confusedItemTwo = "Bootcamping";
            string confusedItemThree = "women";

            Console.WriteLine("Hello " + instructor + " and " + instructor2 + " I'm swell, but I'm still having problems with "
                              + confusedItemOne + ", " + confusedItemTwo + ", " + confusedItemThree + ".");

            
            string potentialEmployerName = "Mr. Boss";
            string date = DateTime.Today.ToShortDateString();

            string todaysDate = "Dear " + potentialEmployerName + ". Today is " + date + ".";
            string messageUnderstand = " I'm enjoying class. I think I like C# the best out of anything.";
            string messageGoal = " I'd like to get a job as a developer after I finish this course.";

            todaysDate += messageUnderstand;
                todaysDate += messageGoal;

            Console.WriteLine(todaysDate);


            string usernameLow = @"nathanrice";
            string usernameUp = @"NATHANRICE";

        
            bool result = usernameLow.Equals(usernameUp, StringComparison.OrdinalIgnoreCase);
            bool resultTwo = usernameLow.Equals(usernameUp, StringComparison.Ordinal);

            Console.WriteLine("{0} and {1} are {2}", usernameLow, usernameUp,
                                result? "equal." : "not equal.");

            Console.WriteLine("{0} and {1} are {2}", usernameLow, usernameUp,
                                resultTwo? "equal." : "not equal.");

            Console.ReadLine();
        }
    }
}