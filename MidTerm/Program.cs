using System;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> ListMovies = new List<Movie>();
            Menu.AddMovie(ListMovies, new Movie("Avengers: End Game ", "Josh Brolin", "Fantasy", "Russo Brothers"));
            Menu.AddMovie(ListMovies, new Movie("Zoolander ", "Ben Stiller", "Comedy", "Also directed by Ben Stiller"));
            Menu.AddMovie(ListMovies, new Movie("Bee Movie ", "Jerry Seinfeld", "Animated", "Simon J. Smith and Steve Hickner"));
            Menu.AddMovie(ListMovies, new Movie("Smash ", "Applesauce", "Fantasy", "Simon J. Smith and Steve Hickner"));
            Menu.AddMovie(ListMovies, new Movie("Zzz ", "zzzz", "zzzz", "zzzzz"));

            Console.WriteLine("Unsorted");
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }

            Menu.SortByActor(ListMovies);
            Console.WriteLine("Sorted by Actor");
            Console.WriteLine();
            Console.WriteLine();
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }

            Menu.AddMovie(ListMovies, AddMovieHelper());

            Console.WriteLine("After adding");
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }
        }

        public static Movie AddMovieHelper()
        {
            Console.WriteLine("Hello! In order to add a movie, I need a few pieces of information." +
                "\nFirstly, what is the name of this movie?:  ");
            string title = Console.ReadLine();
            Console.WriteLine("Great!  Please enter the leading actor or actress:  ");
            string actor = Console.ReadLine();
            Console.WriteLine("Thank you.  what is the genre of this movie?:  ");
            string genre = Console.ReadLine();
            Console.WriteLine("And last but not least, who directed this movie?:  ");
            string directed = Console.ReadLine();

            return new Movie(title, actor, genre, directed);
        }
    }
}
