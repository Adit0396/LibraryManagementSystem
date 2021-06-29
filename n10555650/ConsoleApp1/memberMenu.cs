using System;
using static System.Console;
namespace Assignment
{
	public class MemberMenu
	{
		ToolLibrary toolLibrary = new ToolLibrary();
		MovieCollection movie = new MovieCollection();
		public void allMovies()// Display all movies
		{
			toolLibrary.displayAllMovies();
		}
		public void displayMovie()// Display Selected Movie
		{
			WriteLine("Enter Title");
			string title = ReadLine();
			toolLibrary.displayOneMovie(title);
		}
		public void borrowMovie()// Borrow movie
		{
			WriteLine("Enter the movie to be borrowed");
			string title = ReadLine();
			Movie borrow = new Movie() { Title = title };
			WriteLine("Enter Member First Name");
			String firstName = ReadLine();
			Member memberBorrow = new Member() { FirstName = firstName };
			borrow.addBorrower(memberBorrow);
			memberBorrow.addMovie(borrow);
			string[] arr = toolLibrary.getMovieDVDs(memberBorrow);
			WriteLine("The Movies rented by the Member" + firstName + " are :");
			for (int i = 0; i < arr.Length; i++)
				WriteLine(arr[i]);
			movie.borrowingMovies(title);
		}
		public void returnMovie()// Return Movie
		{
			WriteLine("Enter the movie to be returned");
			string title = ReadLine();
			Movie returnMovie= new Movie() { Title = title };
			WriteLine("Enter Member First Name");
			String firstName = ReadLine();
			Member memberReturn= new Member() { FirstName = firstName };
			returnMovie.deleteBorrower(memberReturn);
			memberReturn.deleteMovie(returnMovie);
			string[] arr = toolLibrary.getMovieDVDs(memberReturn);
			WriteLine("\nThe Movies rented by the Member " + firstName + " are :");
			for (int i = 0; i < arr.Length; i++)
				WriteLine(arr[i]);
			movie.returningMovies(title);
		}
		public void currentMovie()// Member holding current movies
		{
			WriteLine("Enter Member First Name");
			String firstName = ReadLine();
			Member getMovieDVDs= new Member() { FirstName = firstName };
			string[] arr = toolLibrary.getMovieDVDs(getMovieDVDs);
			Console.WriteLine("The Movies rented by the Member" + firstName + " are :");
			for (int i = 0; i < arr.Length; i++)
				Console.WriteLine(arr[i]);
		}
		public void top3Movie()// Top 3 Rented movies
		{
			toolLibrary.displayTop3();
		}
	}
}