using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm
{
    public class Movie
    {
        private string movieName;
        private string mainActor;
        private string genre;
        private string director;

        public string MovieName { get => movieName; set => movieName = value; }
        public string MainActor { get => mainActor; set => mainActor = value; }
        public string Genre { get => genre; set => genre = value; }
        public string Director { get => director; set => director = value; }

        public Movie(string movieName, string mainActor, string genre, string director)
        {
            this.movieName = movieName;
            this.mainActor = mainActor;
            this.genre = genre;
            this.director = director;
        }

        public override string ToString()
        {
            string j = String.Format("*****************************************************************************************\n" +
                "{0,-28}Main Actor: {1,-20}Genre: {2,-10}Director: {3,-20}", movieName, mainActor, genre, director);
            //return $"Title: {movieName}\t\tActor: {mainActor}\nGenre: {genre}\t\t\tDirector: {director}\n";
            return j;
        }
    }
}
