using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Lab_10_Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List application");

            Console.WriteLine("There are 10 movies in this list.");


            var movies = new List<MovieListBase>();

            movies.Add(new MovieListBase("Drama", "Bombshell"));
            movies.Add(new MovieListBase("Drama", "Serenity"));
            movies.Add(new MovieListBase("Animated", "Frozen II"));
            movies.Add(new MovieListBase("Animated", "Onward"));
            movies.Add(new MovieListBase("Horror", "The Grudge"));
            movies.Add(new MovieListBase("Horror", "The Invisible Man"));
            movies.Add(new MovieListBase("Scifi", "The New Mutants"));
            movies.Add(new MovieListBase("Scifi", "Gemini Man"));
            movies.Add(new MovieListBase("Animated", "The Addams Family"));
            movies.Add(new MovieListBase("Horror", "Escape Room"));


            bool shouldContinue = true;
            while (shouldContinue)
            {
               
                    Console.WriteLine("What category are you interested in ?");
                    string userSelection = Console.ReadLine();
                    foreach (var movie in movies)
                    {


                      if (movie.MovieCategory.Equals(userSelection, StringComparison.OrdinalIgnoreCase))
                      {
                        Console.WriteLine($"{movie.MovieTitle}");

                      }

                      
                    }
                                 

                    Console.WriteLine("Would you like to continue? Type 'yes' to continue and  'no' to exit:");
                    string userChoice = Console.ReadLine();

                    if (userChoice.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;

                    }

                    else if (userChoice.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {


                        Console.WriteLine(" Have a wonderful Day");
                        shouldContinue = false;

                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Please try again.");
                        continue;
                    }

                
            }
        }
    }


    public class MovieListBase
    {


        public string MovieCategory;
        public string MovieTitle;



        public MovieListBase(string category, string title)
        {
            MovieCategory = category;
            MovieTitle = title;
        }

    }


}
