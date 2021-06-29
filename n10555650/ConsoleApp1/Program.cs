using System;
using static System.Console;

namespace Assignment { 
    class Program
    {
        static void Main(string[] args)
        {
            ToolLibrary toolLibrary = new ToolLibrary();
            Movie movie1 = new Movie() { Title = "The Godfather", Genre = "Thriller", Classification = "MA15+", Duration = 120, Availablecopies = 10, Noborrowings = 5 };
            Movie movie2 = new Movie() { Title = "The Shawshank Redemption", Genre = "Drama", Classification = "PG", Duration = 134, Availablecopies = 8, Noborrowings = 2 };
            Movie movie3 = new Movie() { Title = "The Dark Knight", Genre = "Drama", Classification = "MA15+", Duration = 112, Availablecopies = 8, Noborrowings = 5 };
            Movie movie4 = new Movie() { Title = "12 Angry Men", Genre = "Other", Classification = "G", Duration = 150, Availablecopies = 8, Noborrowings = 1};
            Movie movie5 = new Movie() { Title = "Schindler's List", Genre = "Family", Classification = "G", Duration = 140, Availablecopies = 2, Noborrowings = 0 };
            toolLibrary.add(movie2);
            toolLibrary.add(movie1);
            toolLibrary.add(movie3);
            toolLibrary.add(movie4);
            toolLibrary.add(movie5);
            Member members = new Member() { FirstName = "Virat", ContactNumber = "0432715253", LastName = "Kohli", Pin = 0305 };
            Member members1 = new Member() { FirstName = "MS", ContactNumber = "0432746868", LastName = "Dhoni", Pin = 0108 };
            toolLibrary.add(members);
            toolLibrary.add(members1);


            Write("=========================");
            WriteLine("\nCOMMUNITY LIBRARY MOVIE AND DVD MANAGEMENT");
            WriteLine("======================");
            WriteLine("\n Main Menu");
            WriteLine("----------------------");
            WriteLine("Select from the following:");
            WriteLine("\n 1.Staff ");
            WriteLine("\n 2.Member");
            WriteLine("\n 0.End the program ");
            WriteLine("\n Enter your choice ==>");
            bool validity= true;
            do
            {
                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                    Console.WriteLine("Try again");
                if (choice == 1)
                {
                    int subchoice;
                    do
                    {

                        WriteLine("Please Enter your Staff User Name");
                        string userName = ReadLine();
                        WriteLine("Please Enter your Staff Password");
                        string passWord = ReadLine();
                        if (userName == "staff" && passWord == "today123")
                        {
                            subchoice = 2;
                            break;
                        }
                        else
                        {
                            WriteLine("Please enter Correct details. 1 to continue or 0 to exit");
                            subchoice = Convert.ToInt32(ReadLine());
                        }
                        if (subchoice == 1)
                            continue;
                        if (subchoice == 0)
                            break;

                    } while (subchoice == 0 || choice == 1);
                    if (subchoice == 0)
                        break;
                    if (subchoice == 2)
                        staffMenu();
                    break;
                }
                if (choice == 2)
                {

                    memberMenu();
                    break;
                }
                if (choice == 0)
                {
                    ReadKey();
                    break;
                }
                else
                {
                    WriteLine("Not a Valid Number. Enter nmumber again");
                    validity = false;
                }
            } while (validity == false);
        }
        public static void staffMenu()
        {
            bool exit = false;
            do
            {
                WriteLine("\nStaff Menu");
                WriteLine("------------------------");
                WriteLine("1. Add DVDs of new movie to the system");
                WriteLine("2. Add DVDs of existing movie to the system");
                WriteLine("3. Remove a DVD from the system");
                WriteLine("4. Register a new member to the system");
                WriteLine("5. Remove a registered member fromm the system");
                WriteLine("6. Find a member's Contact phone number, given the member's name");
                WriteLine("7. Find Members who are currently renting a particular movie");
                WriteLine("0. Return to main menu");
                WriteLine("Enter your choice");
                int choice = Convert.ToInt32(ReadLine());
                StaffMenu staffMenu = new StaffMenu();
                
                if (choice == 1)
                {
                    staffMenu.add();
                }
                if (choice == 2)
                    staffMenu.existingDVDs();
                if (choice == 3)
                    staffMenu.remove();
                if (choice == 4)
                    staffMenu.addMember();
                if (choice == 5)
                    staffMenu.delete();
                if (choice == 6)
                    staffMenu.getConnectPhone();
                if (choice == 7)
                    staffMenu.rentingMovie();
                if (choice == 0)
                    exit =true;
            } while (exit != true);
        }
            
        public static void memberMenu()
        {
            bool exit = false;
            do
            {

                WriteLine("Member Menu");
                WriteLine("------------------------");
                WriteLine("1.Browse all the movies");
                WriteLine("2.Display all the information about a movie, given the title of the movie");
                WriteLine("3.Borrow a movie DVD");
                WriteLine("4.Return  a movie DVD");
                WriteLine("5.List current borrowing movies");
                WriteLine("6.Display the top 3 movies rented by the members");
                WriteLine("0.Return to main menu");
                WriteLine("Enter your choice");
                int choice = Convert.ToInt32(ReadLine());
                MemberMenu memberMenu = new MemberMenu();
                if (choice == 1)
                    memberMenu.allMovies();
                if (choice == 2)
                    memberMenu.displayMovie();
                if (choice == 3)
                    memberMenu.borrowMovie();
                if (choice == 4)
                    memberMenu.returnMovie();
                if (choice == 5)
                    memberMenu.currentMovie();
                if (choice == 6)
                    memberMenu.top3Movie();
            } while (exit != true);

        }
    }
}
