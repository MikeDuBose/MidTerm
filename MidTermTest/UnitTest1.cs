using System;
using Xunit;
using MidTerm;
using MidTermTest;
using System.Collections.Generic;

namespace MidTermTest
{
    public class UnitTest1
    {

        [Fact]
        public void CheckAddMovieToList()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("A", "B", "C", "D"));
            Assert.Equal("A", mList[0].MovieName);
        }

        [Fact]
        public void CheckSortMovieList_Title_ZeroIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByName(mList);
            Assert.Equal("A", mList[0].MovieName);
        }
        [Fact]
        public void CheckSortMovieList_Title_FirstIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByName(mList);
            Assert.Equal("E", mList[1].MovieName);
        }

        [Fact]
        public void CheckSortMovieList_Title_SecondIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByName(mList);
            Assert.Equal("Z", mList[2].MovieName);
        }

        [Fact]
        public void CheckSortMovieList_Genre_ZeroIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));            
            Menu.SortByGenre(mList);
            Assert.Equal("C", mList[0].Genre);
        }

        [Fact]
        public void CheckSortMovieList_Genre_FirstIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByGenre(mList);
            Assert.Equal("G", mList[1].Genre);
        }

        [Fact]
        public void CheckSortMovieList_Genre_SecondIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByGenre(mList);
            Assert.Equal("Y", mList[2].Genre);
        }

        [Fact]
        public void CheckSortMovieList_Actor_ZeroIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByActor(mList);
            Assert.Equal("B", mList[0].MainActor);
        }

        [Fact]
        public void CheckSortMovieList_Actor_FirstIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByActor(mList);
            Assert.Equal("F", mList[1].MainActor);
        }

        [Fact]
        public void CheckSortMovieList_Actor_SecondIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByActor(mList);
            Assert.Equal("X", mList[2].MainActor);
        }

        [Fact]
        public void CheckSortMovieList_Director_ZeroIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByDirector(mList);
            Assert.Equal("D", mList[0].Director);
        }

        [Fact]
        public void CheckSortMovieList_Director_FirstIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByDirector(mList);
            Assert.Equal("H", mList[1].Director);
        }

        [Fact]
        public void CheckSortMovieList_Director_SecondIndex()
        {
            List<Movie> mList = new List<Movie>();
            mList.Add(new Movie("Z", "X", "Y", "W"));
            mList.Add(new Movie("E", "F", "G", "H"));
            mList.Add(new Movie("A", "B", "C", "D"));
            Menu.SortByDirector(mList);
            Assert.Equal("W", mList[2].Director);
        }

        [Fact]
        public void CheckTitle_Pass()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckTitle("Bee movie");       
            Assert.True(flag);
        }

        [Fact]
        public void CheckTitle_Fail()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckTitle("bee mov");
            Assert.False(flag);
        }
        [Fact]
        public void CheckDirector_Pass()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckDirector("russo brothers");
            Assert.True(flag);
        }

        [Fact]
        public void CheckDirector_Fail()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckDirector("russ bros");
            Assert.False(flag);
        }

        [Fact]
        public void CheckActor_Pass()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckActor("ben stiller");
            Assert.True(flag);
        }

        [Fact]
        public void CheckActor_Fail()
        {
            Program.InstantiateMenu();
            bool flag = Program.CheckActor("sten biller");
            Assert.False(flag);
        }

        [Fact]
        public void CheckTitle_AfterAdd_Pass()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckTitle("little miss sunshine");
            Assert.True(flag);
        }
        [Fact]
        public void CheckTitle_AfterAdd_Fail()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckTitle("little mister sunshine");
            Assert.False(flag);
        }

        [Fact]
        public void CheckDirector_AfterAdd_Pass()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckDirector("socrates katrivesis");
            Assert.True(flag);
        }

        [Fact]
        public void CheckDirector_AfterAdd_Fail()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckDirector("katrivei");
            Assert.False(flag);
        }

        [Fact]
        public void CheckActor_AfterAdd_Pass()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckActor("Riley Shirk");
            Assert.True(flag);
        }

        [Fact]
        public void CheckActor_AfterAdd_Fail()
        {
            Program.InstantiateMenu();
            Menu.AddMovie(Program.ListMovies, new Movie("Little Miss Sunshine", "Riley Shirk", "Comedy", "Socrates Katrivesis"));
            bool flag = Program.CheckActor("little miss sunshine");
            Assert.False(flag);
        }
    }
}
