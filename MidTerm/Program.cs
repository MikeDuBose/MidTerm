using System;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        static List<Movie> ListMovies = new List<Movie>();
        static void Main(string[] args)
        {
            //Instantiating the movie list.
            //This could possibly be moved to the menu initialization.
            //Would have to refactor everything?  All methods are static - how does this affect my code?
            Menu.AddMovie(ListMovies, new Movie("Avengers: End Game", "Josh Brolin", "Fantasy", "Russo Brothers"));
            Menu.AddMovie(ListMovies, new Movie("Zoolander", "Ben Stiller", "Comedy", "Also directed by Ben Stiller"));
            Menu.AddMovie(ListMovies, new Movie("Bee Movie", "Jerry Seinfeld", "Animated", "Simon J. Smith and Steve Hickner"));
            Menu.AddMovie(ListMovies, new Movie("Smash", "Applesauce", "Fantasy", "Simon J. Smith and Steve Hickner"));
            Movie z = new Movie("Zzz", "zzzz", "zzzz", "zzzzz");
            Menu.AddMovie(ListMovies, z);
            //end of instantiation
            //Call the program while the user would like to continue
            do
            {
                PrintMenu();
                MenuDisplay();
            }
            while (Continue());

        }
        //Gets some info from the user and returns a movie to add to the movie list.
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
            //returns a movie with the specifications the user entered
            return new Movie(title, actor, genre, directed);
        }

        public static void MenuDisplay()
        {
            Console.WriteLine("Please select something to do:\n1\tAdd a movie\n2\tRemove a movie\n3\tSort\n4\tEdit a movie\nWhat would you like to select? (1-4)");
            bool validated = int.TryParse(Console.ReadLine(), out int input);
            if (validated)
            {

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
                        Console.WriteLine("Please enter the title of the movie you would like to edit.");
                        string titSel = Console.ReadLine().ToLower();
                        if (CheckTitle(titSel))
                        {
                            foreach (Movie m in ListMovies)
                            {
                                if (m.MovieName.ToLower() == titSel)
                                {
                                    Menu.EditMovie(m);
                                }  
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid title name");                           
                        }
                        break;
                    default:
                        Console.WriteLine("That was an invalid input.  Please try again.\n\n");
                        MenuDisplay();
                        break;
                }
            }
            else
            {
                Console.WriteLine("That wasn't a number!\n\n");
                MenuDisplay();
            }

        }

        public static void PrintMenu()
        {
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }
        }

        public static bool Continue()
        {
            Console.Write("Continue? Y/N: ");
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid option.  Please try again.");
                Continue();
                return false;
            }

        }

        public static bool CheckTitle(string title)
        {
            string[] arrString = new string[ListMovies.Count];
            for (int i = 0; i < ListMovies.Count; i++)
            {
                arrString[i] = ListMovies[i].MovieName;
            }

            for (int j = 0; j < arrString.Length; j++)
            {
                if (arrString[j].ToLower() == title.ToLower())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
