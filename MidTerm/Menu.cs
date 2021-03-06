﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    public class Menu
    {
        //Adds a movie (m) to the list (l)
        public static void AddMovie(List<Movie> l, Movie m)
        {
            l.Add(m);
        }
        //Removes a movie (m) from the list (l)
        public static void RemoveMovie(List<Movie> l, Movie m)
        {
            l.Remove(m);
        }

        //This sort method allows the list to be sorted in place by comparing actors
        public static List<Movie> SortByActor(List<Movie> l)
        {
            l.Sort((x, y) => x.MainActor.CompareTo(y.MainActor));
            return l;
        }

        //This sort method allows the list to be sorted in place by comparing titles
        public static List<Movie> SortByName(List<Movie> l)
        {
            l.Sort((x, y) => x.MovieName.CompareTo(y.MovieName));
            return l;
        }

        //This sort method allows the list to be sorted in place by comparing directors
        public static List<Movie> SortByDirector(List<Movie> l)
        {
            l.Sort((x, y) => x.Director.CompareTo(y.Director));
            return l;
        }

        //This sort method allows the list to be sorted in place by comparing genre
        public static List<Movie> SortByGenre(List<Movie> l)
        {
            l.Sort((x, y) => x.Genre.CompareTo(y.Genre));
            return l;
        }

        //Prompts the user to edit a movie.
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
            Console.Clear();
            Program.PrintMenu();
            Console.WriteLine("Your movie has been edited.\n\n");
            Program.MenuDisplay();
        }
    }
}
