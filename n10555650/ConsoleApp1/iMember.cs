
using System.Collections.Generic;

namespace Assignment
{
    //The specification of Member ADT
    interface iMember
    {
        string FirstName  //get and set the first name of this member
        {
            get;
            set;
        }
        string LastName //get and set the last name of this member
        {
            get;
            set;
        }

        string ContactNumber //get and set the contact number of this member
        {
            get;
            set;
        }

        int Pin //get and set a four-digit pin number
        {
            get;
            set;
        }

		string[] getBorrowingMovieDVDs //get a list of movies that this memebr is currently borrowing
        { get;}

		void addMovie(iMovie aMovie); //add a given movie DVD to the list of movies DVDs that this member is currently holding

        void deleteMovie(iMovie aMovie); //delete a given movie DVD from the list of movie DVDs that this member is currently holding

        //public abstract override string ToString();  // return a string containing the first name, last name and contact number of this memeber 
    }
    class Member : iMember
    {
        static List<string> movies = new List<string>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public int Pin { get; set; }
        public string[] getBorrowingMovieDVDs {            
            get {                
                return movies.ToArray(); } }
        public void addMovie(iMovie aMovie)
        {
            movies.Add(aMovie.Title);
        
        }
        public void deleteMovie(iMovie aMovie) {
            movies.Remove(aMovie.Title);
        }
       
        public override string ToString()
        {
            return "FirstName:" + this.FirstName + "\t LastName:" + this.LastName + "\tContactNumber:" + this.ContactNumber + "\tPin" + this.Pin;
        }

    }
}
