using System;
using static System.Console;

namespace Assignment
{
    public class StaffMenu
    {
        ToolLibrary toolLibrary = new ToolLibrary(); // One time call statement for Class ToolLibrarary
        public void add()// function to add movie into string 
        {
            string title; string genre; string classification; int duration; int availablecopies; int noborrowings;
            WriteLine("enter title");
            title = ReadLine();
            WriteLine("enter genre");
            genre = ReadLine();
            WriteLine("enter classification");
            classification = ReadLine();
            WriteLine("enter duration");
            duration = Convert.ToInt32(ReadLine());
            WriteLine("enter availablecopies");
            availablecopies = Convert.ToInt32(ReadLine());
            WriteLine("enter no of borrowings");
            noborrowings = Convert.ToInt32(ReadLine());
            Movie movie = new Movie() { Title = title, Genre = genre, Classification = classification, Duration = duration, Availablecopies = availablecopies, Noborrowings = noborrowings };
            toolLibrary.add(movie);
            toolLibrary.displayAllMovies();
        }     
        public void existingDVDs()// Member for adding existing movie DVDs
        {
            MovieCollection movieCollection = new MovieCollection();
            bool i;
            do
            {
                string title;
                WriteLine("Enter title");
                title = ReadLine();
                Movie moviesearch = new Movie() { Title = title };
                {
                    WriteLine("Enter quantity ");
                    int quantity = Convert.ToInt32(ReadLine());
                    toolLibrary.add(moviesearch, quantity);
                    toolLibrary.displayOneMovie(title);
                    i = true;
                    break;
                }
            } while (i == false);
        }

        public void remove()// Remove DVDs from System. Delete if Zero
        {
            MovieCollection movieCollection = new MovieCollection();
            string title;
            WriteLine("Enter title");
            title = ReadLine();
            bool remove = movieCollection.removeDVD(title);
            if (remove == true)
                WriteLine("Sorry Movie not present");
            else
                movieCollection.displayMovie(title);
        }
        public void addMember()// Add member into the system
        {
            WriteLine("enter First Name");
            string firstName = ReadLine();
            WriteLine("enter Last Name");
            string lastName = ReadLine();
            WriteLine("Enter Contact Number");
            string contactNumber = ReadLine();
            WriteLine("enter Pin");
            int pin = Convert.ToInt32(ReadLine());
            Member member = new Member() { FirstName = firstName, ContactNumber = contactNumber, LastName = lastName, Pin = pin};
            toolLibrary.add(member);
            MemberCollection memberCollection = new MemberCollection();
            memberCollection.display();

        }
        public void delete()// Delete Member
        {
            WriteLine("enter First Name");
            string firstName = ReadLine();
            Member delete = new Member() { FirstName = firstName};
            toolLibrary.delete(delete);
            MemberCollection memberCollection = new MemberCollection();
            memberCollection.display();

        }
        public void getConnectPhone()// Get Contact Details
        {
            WriteLine("enter First Name");
            string firstName = ReadLine();
            WriteLine("enter Last Name");
            string lastName = ReadLine();
            string contactNumber=toolLibrary.getConnectPhone(firstName,lastName);
            WriteLine(contactNumber);
        }
        public void rentingMovie()// Get Members renting movie
        {

        }
    }
}
