using System;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        static List<Movie> ListMovies = new List<Movie>();
        static void Main(string[] args)
        {

            Menu.AddMovie(ListMovies, new Movie("Avengers: End Game", "Josh Brolin", "Fantasy", "Russo Brothers"));
            Menu.AddMovie(ListMovies, new Movie("Zoolander", "Ben Stiller", "Comedy", "Also directed by Ben Stiller"));
            Menu.AddMovie(ListMovies, new Movie("Bee Movie", "Jerry Seinfeld", "Animated", "Simon J. Smith and Steve Hickner"));
            Menu.AddMovie(ListMovies, new Movie("Smash", "Applesauce", "Fantasy", "Simon J. Smith and Steve Hickner"));
            Movie z = new Movie("Zzz", "zzzz", "zzzz", "zzzzz");
            Menu.AddMovie(ListMovies, z);

            //Console.WriteLine("Unsorted");
            //foreach (Movie m in ListMovies)
            //{
            //    Console.WriteLine(m);
            //}

            //Menu.SortByActor(ListMovies);
            //Console.WriteLine("Sorted by Actor");
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (Movie m in ListMovies)
            //{
            //    Console.WriteLine(m);
            //}

            //Menu.AddMovie(ListMovies, AddMovieHelper());

            //Console.WriteLine("After adding");
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }
            MenuDisplay();

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

        public static void MenuDisplay()
        {
            Console.WriteLine("Please select something to do:\n1\tAdd a movie\n2\tRemove a movie\n3\tSort\n4\tEdit a movie\nWhat would you like to select? (1-4)");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Menu.AddMovie(ListMovies, AddMovieHelper());
                    break;
                case 2:
                    Console.Write("What is the title of the movie you would like to remove?:  ");
                    string title = Console.ReadLine().ToLower();
                    for (int i = 0; i < ListMovies.Count; i++)
                    {
                        if (ListMovies[i].MovieName.ToLower() == title)
                        {
                            Menu.RemoveMovie(ListMovies, ListMovies[i]);
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("How would you like to sort your movies?\n1\tTitle\n2\tActor/Actress\n3\tGenre\n4\tDirector\n");
                    int input2 = int.Parse(Console.ReadLine());
                    if (input2 == 1)
                    {
                        Menu.SortByName(ListMovies);
                    }
                    else if (input2 == 2)
                    {
                        Menu.SortByActor(ListMovies);
                    }
                    else if (input2 == 3)
                    {
                        Menu.SortByGenre(ListMovies);
                    }
                    else if (input2 == 4)
                    {
                        Menu.SortByDirector(ListMovies);
                    }
                    Console.WriteLine("Your movies have been sorted!");
                    break;
                case 4:
                    //TODO:  Code a way to edit a movie based on title selection
                    break;
            }

        }
    }
}
