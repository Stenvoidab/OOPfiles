using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string character;
            string wish;

            public Frozen(string _character, string _wish)
            {
                character = _character;
                wish = _wish;
            }
            public string Character
            {
                get { return character; }
            }
            public string Wish
            {
                get { return wish; }
            }

        }

        static void Main(string[] args)
        {
            List<Frozen> myMovies = new List<Frozen>();
            string[] CharacterFromFile = GetDataFromFile();
            string[] WishFromFile = GetDataFromFile();

            foreach (string line in CharacterFromFile )
            {
                string[] temparray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newMovie = new Frozen(temparray[0], temparray[1]);
                myMovies.Add(newMovie);
            }
            foreach (Frozen MovieFromList in myMovies)
            {
                Console.WriteLine($"{MovieFromList.Character} wants {MovieFromList.Wish} for christmas");
            }

        }
        public static void DisplayElementsFromArray(String[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"string from array {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filepath = @"C:\Users\stens\OneDrive\Töölaud\TTK\programeerimine\frozen.txt";
            string[] DataFromFile = File.ReadAllLines(filepath);

            return DataFromFile;
        }


    }
}
