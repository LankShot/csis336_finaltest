using System;
using System.Collections.Generic;

namespace FinalTest
{
    public class InterfacesExercise
    {
        public void Execute()
        {
            Console.WriteLine("\nInterface Exercise:");

            //----------------------------------------------------------------------------------------------------------
            // Exercise:    Below are two classes named Employee and Book.  Create a new interface called IIdentifier
            //              with one read-only string member called Id.  Implement the interface on Employee using the 
            //              EmployeeId for the Id and implement the interface on Book using ISBN for the Id.  Then, create 
            //              a generic list of IIdentifier and add the employees and books from the arrays defined below 
            //              to the list.  
            //              Finally, loop through and write all items in the list to the console, with the Id of the 
            //              IIdentifier first followed by a space and then the ToString() of the object.

            Employee[] employees = Helpers.GetEmployees();
            Book[] books = Helpers.GetBooks();

            List<IIdentifier> items = new List<IIdentifier>();

            foreach(Employee emp in employees){
                items.Add(emp);
            }

            foreach(Book book in books){
                items.Add(book);
            }

            for(int i=0; i < items.Count; i++){
                Console.WriteLine("{0} {1}", items[i].Id, items[i].ToString());
            }

        }
    }

    //TODO: Interface Exercise: Create and implement interface here
    public interface IIdentifier
    {
        string Id {get;}
    }

    public class Employee : IIdentifier
    {
        public string Id {get {return EmployeeId.ToString();}}
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"{FirstName} {LastName}";
    }
    public class Book : IIdentifier
    {

        public string Id {get {return ISBN;}}
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString() => $"{Title} - {Author}";
    }


    // This is a helper class to help populate the arrays.  Don't modify this code.
    public static class Helpers
    {
        public static Employee[] GetEmployees()
        {
            Employee emp1 = new Employee { EmployeeId = 42, FirstName = "Chuck", LastName = "Bartowski" };
            Employee emp2 = new Employee { EmployeeId = 83, FirstName = "Morgan", LastName = "Grimes" };
            return new Employee[] { emp1, emp2 };
        }

        public static Book[] GetBooks()
        {
            Book book1 = new Book { ISBN = "9780141439518", Title = "Pride and Prejudice", Author = "Jane Austen" };
            Book book2 = new Book { ISBN = "9781544088358", Title = "Moby Dick", Author = "Herman Melville" };
            return new Book[] { book1, book2 };
        }
    }

}
