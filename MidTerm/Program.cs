using System;
using System.Collections.Generic;

namespace MidTerm
{
    class Program
    {
        static List<Movie> ListMovies = new List<Movie>();
        static void Main(string[] args)
        {
            InstantiateMenu();
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

        //Displays the user selection menu and calls the appropriate function
        public static void MenuDisplay()
        {
            Console.WriteLine("Please select something to do:\n1\tAdd a movie\n2\tRemove a movie\n3\tSort\n4\tEdit a movie\n5\tFind movie by director\n" +
                "6\tFind movie by actor\n7\tQuit\nWhat would you like to select? (1-7)");
            bool validated = int.TryParse(Console.ReadLine(), out int input);
            if (validated)
            {
                switch (input)
                {
                    case 1:
                        Menu.AddMovie(ListMovies, AddMovieHelper());
                        PrintMenu();
                        MenuDisplay();
                        break;
                    case 2:
                        Console.Write("What is the title of the movie you would like to remove?:  ");
                        string title = Console.ReadLine().ToLower();
                        if (CheckTitle(title))
                        {
                            for (int i = 0; i < ListMovies.Count; i++)
                            {
                                if (ListMovies[i].MovieName.ToLower() == title)
                                {
                                    Menu.RemoveMovie(ListMovies, ListMovies[i]);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("That movie does not exist.");
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
                        else
                        {
                            Console.WriteLine("That was not a valid input.");
                            System.Threading.Thread.Sleep(1500);
                            Console.Clear();
                            PrintMenu();
                            MenuDisplay();
                        }
                        Console.WriteLine("Your movies have been sorted!\n");
                        PrintMenu();
                        break;
                    case 4:
                        Console.WriteLine("Please enter the title of the movie you would like to edit.");
                        string titSel = Console.ReadLine().ToLower();
                        if (CheckTitle(titSel))
                        {

                            for(int i = 0; i < ListMovies.Count; i++)
                            {
                                if (ListMovies[i].MovieName.ToLower() == titSel)
                                {
                                    Menu.EditMovie(ListMovies[i]);
                                }
                            }
                            
                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid title name");
                        }
                        break;
                    case 5:                        
                        FindByDirector();
                        break;
                    case 6:
                        FindByActor();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("That was an invalid input.  Please try again.\n");
                        MenuDisplay();
                        break;
                }
            }
            else
            {
                Console.WriteLine("That wasn't a number!\n");
                MenuDisplay();
            }
        }

        //Prints everything in the list of movies
        public static void PrintMenu()
        {
            foreach (Movie m in ListMovies)
            {
                Console.WriteLine(m);
            }
        }

        //Asks the user to continue
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

        //Sends all m.MovieName from list of movies to an array
        //Then iterates through array, checking to see if the title exists
        //If it does, it returns true - if not, false
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

        public static bool CheckDirector(string director)
        {
            string[] arrString = new string[ListMovies.Count];
            for (int i = 0; i < ListMovies.Count; i++)
            {
                arrString[i] = ListMovies[i].Director;
            }
            for (int j = 0; j < arrString.Length; j++)
            {
                if (arrString[j].ToLower() == director.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckActor(string actor)
        {
            string[] arrString = new string[ListMovies.Count];
            for (int i = 0; i < ListMovies.Count; i++)
            {
                arrString[i] = ListMovies[i].MainActor;
            }
            for (int j = 0; j < arrString.Length; j++)
            {
                if (arrString[j].ToLower() == actor.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        //Instantiates the menu with a pre-determined list of movies
        public static void InstantiateMenu()
        {
            Menu.AddMovie(ListMovies, new Movie("Avengers: End Game", "Josh Brolin", "Fantasy", "Russo Brothers"));
            Menu.AddMovie(ListMovies, new Movie("Zoolander", "Ben Stiller", "Comedy", "Ben Stiller (Director)"));
            Menu.AddMovie(ListMovies, new Movie("Bee Movie", "Jerry Seinfeld", "Animated", "Simon J. Smith and Steve Hickner"));
            Menu.AddMovie(ListMovies, new Movie("The Cabin in the Woods", "Chris Hemsworth", "Horror", "Drew Goddard"));
        }

        public static void FindByDirector()
        {
            Console.Write("Please enter the director's name: ");
            string dir = Console.ReadLine().ToLower();
            if (CheckDirector(dir))
            {
                for (int i = 0; i < ListMovies.Count; i++)
                {
                    if (ListMovies[i].Director.ToLower() == dir)
                    {
                        Console.WriteLine(ListMovies[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("That director does not exist in our records.");
            }
        }

        public static void FindByActor()
        {
            Console.Write("Please enter the actors name: ");
            string act = Console.ReadLine().ToLower();
            if (CheckActor(act))
            {
                for (int i = 0; i < ListMovies.Count; i++)
                {
                    if (ListMovies[i].MainActor.ToLower() == act)
                    {
                        Console.WriteLine(ListMovies[i]);
                    }
                }
            }
            else
            {
                Console.WriteLine("That actor does not exist in our records.");
            }
        }
    }
}
