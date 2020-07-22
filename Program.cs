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

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool continueFlag = true;
            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Halloween", "Horror"));
            movieList.Add(new Movie("The Implication", "Horror"));
            movieList.Add(new Movie("Dumb and Dumber", "Comedy"));
            movieList.Add(new Movie("Big Trouble in Little China", "Comedy"));
            movieList.Add(new Movie("The Daiquri Man", "Horror"));
            movieList.Add(new Movie("Terminator 2", "Action"));
            movieList.Add(new Movie("Predator", "Action"));
            movieList.Add(new Movie("Brokeback Mountain", "Romance"));
            movieList.Add(new Movie("Dayman", "Romance"));
            movieList.Add(new Movie("Troll Toll", "Comedy"));

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
                            titles.Sort();                              //Sorts all the the things
                            foreach (string movieTitle in titles)
                            {
                                Console.WriteLine(movieTitle);          //Writes out the movies on each line in order
                            }
                            Console.WriteLine();                        //Just adds a space for better output formatting
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
                            titles.Sort();
                            foreach (string movieTitle in titles)
                            {
                                Console.WriteLine(movieTitle);
                            }
                            Console.WriteLine();
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
                            titles.Sort();
                            foreach (string movieTitle in titles)
                            {
                                Console.WriteLine(movieTitle);
                            }
                            Console.WriteLine();
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
                            titles.Sort();
                            foreach (string movieTitle in titles)
                            {
                                Console.WriteLine(movieTitle);
                            }
                            Console.WriteLine();
                            break;
                        }


                }
                Console.Write("Continue? (y/n): ");
                string userContinue = YesOrNo(Console.ReadLine());
                if (userContinue == "n")
                {
                    continueFlag = false;
                }
                titles.Clear();     //Clears the ArrayList, so previous searches don't appear on subsequent searches
                Console.Clear();
            }
            Console.WriteLine($"\nOK BYEEEEEEEEE!!!!!!");

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
