
namespace Assignment
{
    interface ToolLibrarySystem
    {
        void add(iMovie aMovie); // add DVDs of a new movie to the system

        void add(iMovie aMovie, int quantity); //add new DVDs of an existing movie to the system

        void delete(iMovie aMovie); //remove a given movie from the system

        void add(iMember aMember); //add a new memeber to the system

        void delete(iMember aMember); //delete a member from the system

        string getConnectPhone(string firstname, string lastname); //given a member's first name and last name, find the contact phone number of this member
        //iMemberCollection getBorrowers(string movieTitle); //given the title of a movie, return all thoe memebrs wo are currently borrowing that movie

        void displayAllMovies(); //display the information about all the movies in the library

        void displayOneMovie(string movieTitle); //display all the information about about amovie, given the title of the movie 

        void borrowMovie(iMember aMember, iMovie aMovie); //a member borrows a movie DVD from the library

        void returnMovie(iMember aMember, iMovie aMovie); //a member returns a movie DVD to the library

        string[] getMovieDVDs(iMember aMember); //get a list of movie DVDs that are currently held by a given member

        void displayTop3(); //Display top three most frequently borrowed movies by the members in the library in the descending order by the number of times the movie has been borrowed.

    }
    class ToolLibrary : ToolLibrarySystem
    {
       


        MovieCollection movieCollection = new MovieCollection();
        MemberCollection memberCollection = new MemberCollection();
        public void add(iMovie aMovie)
        {
            movieCollection.add(aMovie);
        }
        public void add(iMovie aMovie, int quantity) {
            movieCollection.adddvd(aMovie.Title, quantity);
        }
        public void delete(iMovie aMovie) {
            movieCollection.delete(aMovie);
        }
        public void add(iMember aMember) {
            
            memberCollection.add(aMember);
        }
        public void delete(iMember aMember) {
            memberCollection.delete(aMember);
        }
        public string getConnectPhone(string firstname, string lastname) {
            return memberCollection.getConnectPhone(firstname, lastname);
             }
        //public iMemberCollection getBorrowers(string movieTitle){}
          
        public void displayAllMovies() {
            movieCollection.displayAll();
        }
        public void displayOneMovie(string movieTitle) {
            movieCollection.displayMovie(movieTitle);
        }
        public void borrowMovie(iMember aMember, iMovie aMovie) {
            Movie movie = new Movie();
            Member member = new Member();
            movie.addBorrower(aMember);
            
        }
        public void returnMovie(iMember aMember, iMovie aMovie) {
            Movie movie = new Movie();
            Member member = new Member();
            movie.deleteBorrower(aMember);
          
        }
        public string[] getMovieDVDs(iMember aMember){
            Member getMovieDVDs= new Member() { FirstName = aMember.FirstName};
            string[] arr = getMovieDVDs.getBorrowingMovieDVDs;
            return arr;
        }
        public void displayTop3() 
        {
            MovieCollection movie = new MovieCollection();
            movie.totalborrowings();
        }
    }

}
