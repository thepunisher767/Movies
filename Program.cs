using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Movies
{
    class Movie
    {
        private string _title;
        private string _category;
        private int _year;

        public Movie(string title, string category, int year)
        {
            _title = title;
            _category = category;
            _year = year;
        }
        public string Title
        {
            get
            {
                return _title;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Halloween", "Horror", 1978));
            movieList.Add(new Movie("The Implication", "Horror", 2010));
            movieList.Add(new Movie("Dumb and Dumber", "Comedy", 1994));
            movieList.Add(new Movie("Big Trouble in Little China", "Comedy", 1986));
            movieList.Add(new Movie("The Daiquri Man", "Horror", 2016));
            movieList.Add(new Movie("Terminator 2", "Action", 1991));
            movieList.Add(new Movie("Predator", "Action", 1987));
            movieList.Add(new Movie("Brokeback Mountain", "Romance", 2005));
            movieList.Add(new Movie("Dayman", "Romance", 2008));
            movieList.Add(new Movie("Troll Toll", "Comedy", 2008));

            ArrayList titles = new ArrayList(); //Using this list later to sort

            while (continueFlag)    //While the user wants to continue
            {
                Console.WriteLine("Welcome to the Movie list Application!\n");
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Comedy");
                Console.WriteLine("3. Horror");
                Console.WriteLine("4. Romance\n");
                Console.Write("What category are you interested in? (1-4): ");
                string userChoice = SelectCategory(Console.ReadLine()); //Check for good input

                switch (userChoice) //Do a thing depending on what was selected
                {
                    case "1":
                        {
                            for (int i = 0; i < movieList.Count; i++)
                            {
                                if (movieList[i].Category == "Action")  //Checks for category on each movie through the loop
                                {
                                    titles.Add(movieList[i].Title);     //Adds movies to ArrayList for alphabetical sort
                                }  
                            }
                            MovieOutput(movieList, titles);
                            break;
                        }
                    case "2":
                        {
                            for (int i = 0; i < movieList.Count; i++)
                            {
                                if (movieList[i].Category == "Comedy")
                                {
                                    titles.Add(movieList[i].Title);
                                }
                            }
                            MovieOutput(movieList, titles);
                            break;
                        }
                    case "3":
                        {
                            for (int i = 0; i < movieList.Count; i++)
                            {
                                if (movieList[i].Category == "Horror")
                                {
                                    titles.Add(movieList[i].Title);
                                }
                            }
                            MovieOutput(movieList, titles);
                            break;
                        }
                    case "4":
                        {
                            for (int i = 0; i < movieList.Count; i++)
                            {
                                if (movieList[i].Category == "Romance")
                                {
                                    titles.Add(movieList[i].Title);
                                }
                            }
                            MovieOutput(movieList, titles);
                            break;
                        }
                }
                Console.Write("Continue? (y/n): ");
                string userContinue = YesOrNo(Console.ReadLine());  //Are we doing this again, or what?!?!?!?!?!
                if (userContinue == "n")
                {
                    continueFlag = false;
                }
                titles.Clear();     //Clears the ArrayList, so previous searches don't appear on subsequent searches
                Console.Clear();
            }
            Console.WriteLine($"\nOK BYEEEEEEEEE!!!!!!");
        }

        private static void MovieOutput(List<Movie> movieList, ArrayList titles)
        {
            titles.Sort();      //Sorts the ArrayList in alphabetical order
            foreach (string movieTitle in titles)   //Loops through each element
            {
                int yearMade = 0;
                for (int i = 0; i < movieList.Count; i++)   //MOAR LOOOOOOPS! 
                {
                    if (movieTitle == movieList[i].Title)       //Checks current movieTitle element against List<Movie>. If it matches, it will pull the year and save it to a variable for output.
                    {
                        yearMade = movieList[i].Year;
                    }
                }
                Console.WriteLine($"{movieTitle} - {yearMade}");    //Writes out the movies on each line in order
            }
            Console.WriteLine();                        //Just adds a space for better output formatting
        }

        public static string SelectCategory(string answer) //method to check (y/n)
        {
            while (answer != "1" && answer != "2" && answer != "3" && answer != "4")
            {
                Console.Write("Please enter valid input (1-4): ");
                answer = Console.ReadLine();
                Console.WriteLine();
            }
            return answer;
        }

        public static string YesOrNo(string answer) //method to check (y/n)
        {
            answer = answer.ToLower();
            while (answer != "y" && answer != "n")
            {
                Console.Write("Please enter valid input (y/n): ");
                answer = Console.ReadLine();
                answer = answer.ToLower();
                Console.WriteLine();
            }
            return answer;
        }
    }

    
}
