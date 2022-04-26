using System;
using System.Collections.Generic;
using System.IO;

namespace OOPFiles
{
    class Program
    {
        

        class movie
        {
            string title;
            string rating;
            string year;

            public movie(string _title,string _rating,string _year)
            {
                title = _title;
                rating = _rating;
                year = _year;

            }

            public string Title
            {
                get { return title; }
            }

            public string Rating
            {
                get { return rating; }
            }

            public string Year
            {
                get { return year; }
            }


                
        }

        static void Main(string[] args)
        {
            List<movie> myMovies = new List<movie>();
            string[] MoviesFromFile = GetDataFromFile();
            string[] moviesFromFile = GetDataFromFile();

            foreach(string line in moviesFromFile)
            {
                string[] temparray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                movie newMovie = new movie(temparray[0], temparray[1], temparray[2]);
                myMovies.Add(newMovie);
            }
            foreach(movie MovieFromList in myMovies)
            {
                Console.WriteLine($"Title --> {MovieFromList.Title}, Rating -->{MovieFromList.Rating}, Year --> {MovieFromList.Year}");
            }
                

        }

        public static void DisplayElementsFromArray(String[] someArray)
        {
            foreach(string element in someArray)
            {
                Console.WriteLine($"string from array {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filepath = @"C:\Users\stens\OneDrive\Töölaud\TTK\programeerimine\New folder\movies.txt";
            string[] DataFromFile = File.ReadAllLines(filepath);

            return DataFromFile;

        }
    }     
    
    

}    
    


        




