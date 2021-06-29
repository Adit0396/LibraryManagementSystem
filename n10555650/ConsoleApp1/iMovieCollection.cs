using System;
using System.Collections.Generic;
using System.Collections;
using static System.Console;
using System.Linq;

namespace Assignment
{
    public static class Extensions
    {
        public static IEnumerator<T> GetEnumerator<T>(this IEnumerator<T> enumerator) => enumerator;
    }

    //The specification of MovieCollection ADT, which is used to store and manipulate a collection of movies
    interface iMovieCollection
    {
        int Number // get the number of movies in the community library
        {
            get;
        }
        void add(iMovie aMovie); //add a given movie to this tool collection
        void delete(iMovie aMovie); //delete a given movie from this movie collection

        Boolean search(iMovie aMovie); //search a given movie in this movie collection. Return true if this movie is in the movie collection; return false otherwise

        void clear(); //remove all the movies in this movie collection
        iMovie[] toArray(); //output the movies in this collection to an array of iMovies
    }

    class MovieCollection : iMovieCollection
    {
       
        static hashtable<object> hashtbale = new hashtable<object>(10);
        public int Number { get; }
        public int position = -1;
        public void add(iMovie aMovie)
        {
            hashtable.Add(aMovie.Title, aMovie);
        }
        public void delete(iMovie aMovie)
        {
            hashtable.Remove(aMovie.Title);
        }

        public bool removeDVD(string title)
        {
            foreach (DictionaryEntry item in hashtable)
            {
                if ((item.Value as Movie).Title == title)
                {
                    if ((item.Value as Movie).Availablecopies > 0)
                    {
                        (item.Value as Movie).Availablecopies += (-1);
                        return false;
                    }
                    else
                        return true;
                }
                else
                    continue;
            }
            return true;
        }
        static Hashtable hashtable = new Hashtable();
        public void clear()
        {
            hashtable.Clear();
        }
        
        public Boolean search(iMovie aMovie)
        {
            if (hashtable.ContainsKey(aMovie))
                return true;
            else
                return false;
        }
        public void adddvd(string title, int quantity)
        {
            foreach (DictionaryEntry item in hashtable)
            {
                if ((item.Value as Movie).Title == title)
                {
                    (item.Value as Movie).Availablecopies = (item.Value as Movie).Availablecopies + quantity;

                }
                else
                    continue;
            }
        }
        
        public iMovie[] toArray()
        {
            iMovie[] movieArray = new iMovie[hashtable.Count];
            hashtable.CopyTo(movieArray, 0);
            for (int i = 0; i < movieArray.Length; i++)
                WriteLine(movieArray[i]);
            return movieArray;
        }
       
        public void displayMovie(string movie)
        {
            foreach (DictionaryEntry item in hashtable)
            {
                if ((item.Value as Movie).Title == movie)
                {
                    Console.WriteLine("Title:" + (item.Value as Movie).Title);
                    Console.WriteLine("Genre: " + (item.Value as Movie).Genre);
                    Console.WriteLine("Classification: " + (item.Value as Movie).Classification);
                    Console.WriteLine("Duration: " + (item.Value as Movie).Duration);
                    Console.WriteLine("Availablecopies" + (item.Value as Movie).Availablecopies);
                    Console.WriteLine("Noborrowings" + (item.Value as Movie).Noborrowings);
                    Console.WriteLine();
                }
                else
                    continue;
            }
        }
        public void displayAll()
        {

            List<string> list = new List<string>();
            var dictionary = new Dictionary<string, int>();
            foreach (DictionaryEntry item in hashtable)
            {
                dictionary.Add((item.Value as Movie).Title, (item.Value as Movie).Availablecopies);
                list = dictionary.Keys.ToList();
            }

            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, dictionary[key]);
            }
        }
        public void borrowingMovies(string title)// Increase NoBorrowers and Decrease Available
        {
            foreach (DictionaryEntry item in hashtable)
            {
                if ((item.Value as Movie).Title == title)
                {
                    (item.Value as Movie).Noborrowings = (item.Value as Movie).Noborrowings + 1;
                    (item.Value as Movie).Availablecopies = (item.Value as Movie).Noborrowings - 1;
                }
                else
                    continue;
            }
        }
        public void returningMovies(string title)//Increase Available and Decrease borrowing
        {
            foreach (DictionaryEntry item in hashtable)
            {
                if ((item.Value as Movie).Title == title)
                {
                    (item.Value as Movie).Noborrowings = (item.Value as Movie).Noborrowings -1;
                    (item.Value as Movie).Availablecopies = (item.Value as Movie).Availablecopies + 1;
                }
                else
                    continue;
            }
        }
        public void totalborrowings()// Truncate to Display TOP3
        {
            List<Tuple<int, string>> mylist = new List<Tuple<int, string>>();

            foreach (DictionaryEntry item in hashtable)
            {
                mylist.Add(new Tuple<int, string>((item.Value as Movie).Noborrowings, (item.Value as Movie).Title));
            }
            var newList = mylist.OrderByDescending(x => x.Item1).ThenBy(x => x.Item2).ToList();
            var newlist =newList.Take(3);

            foreach (object item in newlist)
            {
                WriteLine(item);
            }
        }
    }
}
 

