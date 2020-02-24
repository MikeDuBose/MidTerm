using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    public class Menu
    {
        List<Movie> movieList = new List<Movie>();

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
            l.Sort((x, y) => x.Genre.CompareTo(y.Genre));
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

    }

    
}
