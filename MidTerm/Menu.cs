using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    public class Menu
    {
        public static void AddMovie(List<Movie> l, Movie m)
        {
            l.Add(m);
        }

        public static void RemoveMovie(List<Movie> l, Movie m)
        {
            l.Remove(m);
        }

        public static List<Movie> FindByActor(List<Movie> l, string actor)
        {
            List<Movie> MovieMatch = new List<Movie>();
            foreach (Movie m in l)
            {
                if (m.MainActor.ToLower() == actor.ToLower())
                {
                    MovieMatch.Add(m);
                }
            }
            return MovieMatch;
        }

        public static List<Movie> FindByDirector(List<Movie> l, string director)
        {
            List<Movie> MovieMatch = new List<Movie>();
            foreach (Movie m in l)
            {
                if (m.Director.ToLower() == director.ToLower())
                {
                    MovieMatch.Add(m);
                }
            }
            return MovieMatch;
        }

        public static List<Movie> SortByActor(List<Movie> l)
        {
            l.Sort((x, y) => x.MainActor.CompareTo(y.MainActor));
            return l;
        }

        public static List<Movie> SortByName(List<Movie> l)
        {
            l.Sort((x, y) => x.MovieName.CompareTo(y.MovieName));
            return l;
        }

        public static List<Movie> SortByDirector(List<Movie> l)
        {
            l.Sort((x, y) => x.Director.CompareTo(y.Director));
            return l;
        }

        public static List<Movie> SortByGenre(List<Movie> l)
        {
            l.Sort((x, y) => x.Genre.CompareTo(y.Genre));
            return l;
        }

        public static void EditMovie(Movie m)
        {
            Console.WriteLine("What would you like to edit? (1-4)");
            Console.WriteLine("1\tTitle\n2\tActor\n3\tGenre\n4\tDirector\n");
            string i = Console.ReadLine();
            bool validated = int.TryParse(i, out int cheeky);

            if (validated)
            {
                int sel = int.Parse(i);
                if (sel == 1)
                {
                    Console.Write("\nPlease enter a new title for the movie: ");
                    m.MovieName = Console.ReadLine();
                }
                else if (sel == 2)
                {
                    Console.Write("\nPlease enter a new actor or actress for the movie: ");
                    m.MainActor = Console.ReadLine();
                }
                else if (sel == 3)
                {
                    Console.Write("\nPlease enter a new genre for the movie: ");
                    m.Genre = Console.ReadLine();
                }
                else if (sel == 4)
                {
                    Console.Write("\nPlease enter a new director for the movie: ");
                    m.Director = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid selection.  Please try again.\n\n");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    EditMovie(m);
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.  Please try again.\n\n");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                EditMovie(m);
            }
            Program.PrintMenu();
            Program.MenuDisplay();
        }
    }
}
