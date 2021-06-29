using System.Collections.Generic;


namespace Assignment
{
    //The specification of Movie ADT
    interface iMovie
    {
        string Title // get and set the tile of this movie
        {
            get;
            set;
        }
        string Genre //get and set the genre of this movie
        {
            get;
            set;
        }

        string Classification //get and set the classification of this movie
        {
            get;
            set;
        }

        int Duration //get and set the duration of this movie
        {
            get;
            set;
        }

        int Availablecopies //get and set the number of the copies of this movie currently available to lend
        {
            get;
            set;
        }

        int Noborrowings //get and set the number of times that this movie has been borrowed
        {
            get;
            set;
        }
        iMemberCollection getBorrowers  //get all the members who are currently holding this tool
        {
            get;
        }
        void addBorrower(iMember aMember); //add a member to the borrower list
        void deleteBorrower(iMember aMember); //delte a member from the borrower list
        //public override string ToString();//return a string containning the title, genre, classification, duration, and the number of copies of this movie currently in the community library
    }

    class Movie : iMovie
    {
        MovieCollection movieCollection = new MovieCollection();
        static List<iMember> member= new List<iMember>();
        MemberCollection borrowers = new MemberCollection();
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Classification { get; set; }

        public int Duration { get; set; }
        public int Availablecopies { get; set; }
        public int Noborrowings { get; set; }
        public override string ToString()//return a string containning the title, genre, classification, duration, and the number of copies of this movie currently in the community library
        {
         return "Title:" + this.Title+ "\t Genre:" + this.Genre + "\tClassification:" + this.Classification + "\tDuration" + this.Duration + "\tAvailablecopie" + this.Availablecopies + "\tNoborrowings" + this.Noborrowings;
        }
        public iMemberCollection getBorrowers 
        { 
            get  
            { 
                return borrowers;
            } 
        }
        public void addBorrower(iMember aMember) {
            member.Add(aMember);
            

        }
        public void deleteBorrower(iMember aMember) {
            member.Remove(aMember);
            this.Availablecopies--;
        }
    }
}

