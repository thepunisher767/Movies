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

            ArrayList titles = new ArrayList();


            while (continueFlag)
            {
                Console.WriteLine("Welcome to the Movie list Application!\n");
                Console.WriteLine("1. Action");
                Console.WriteLine("2. Comedy");
                Console.WriteLine("3. Horror");
                Console.WriteLine("4. Romance\n");
                Console.Write("What category are you interested in? (1-4): ");
                string userChoice = SelectCategory(Console.ReadLine());

                //Console.WriteLine(userChoice);

                switch (userChoice)
                {
                    case "1":
                        {
                            for (int i = 0; i < movieList.Count; i++)
                            {
                                if (movieList[i].Category == "Action")
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
                titles.Clear();
                Console.Clear();
            }

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
