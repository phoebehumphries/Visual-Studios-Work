using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Input
{
  public class Program
    {
        static List<Person> people;

        static void Main(string[] args)
        {

            if (people == null)
            {
                people = new List<Person>();
            }

            menuCode();
           
        }
        static void createTestUsers()
        {
            //create a person.
            Person p1 = new Person();
            //access and assign new person's Firstname Property to a string.
            p1.Firstname = "Phoebe";
            p1.Surname = "Humphries";
            //create a string variable that is what we expect a date to be.
            string p1dob = "15/09/1999";
            DateTime dt1 = Convert.ToDateTime(p1dob);
            //assign the datetime variable to the p1 instance of the Person object.
            p1.Dob = dt1;

            Person p2 = new Person();
            p2.Firstname = "Molly";
            p2.Surname = "Muir";
            string p2dob = "23/11/1999";
            DateTime dt2 = Convert.ToDateTime(p2dob);
            p2.Dob = dt2;

            //add person to the list
            people.Add(p1);
            people.Add(p2);
        }

       public static void newUsers()
        {
            Person p0 = new Person();
            Console.WriteLine("What is your firstname?");
            string new_firstname = Console.ReadLine();
            p0.Firstname = new_firstname;
            Console.WriteLine("What is your surname?");
            string new_surname = Console.ReadLine();
            p0.Surname = new_surname;
            Console.WriteLine("Please enter your date of birth in the form, dd/mm/yyyy");
            string new_dob = Console.ReadLine();
            DateTime dt0 = Convert.ToDateTime(new_dob);
            p0.Dob = (dt0);
            people.Add(p0);

            printListOfUsers();
            Console.WriteLine();
  
        }
        
       public static void printListOfUsers()
        {
            //interates through the people list and print's their details.
            foreach (var person in people)
            {
                
                Console.WriteLine(string.Format("{0} {1} was born on the {2} and they are {3} years old.",
                    person.Firstname, person.Surname,
                    person.Dob.ToString("dd/MM/yyyy"), person.Age));

            }
        }

       public static void backToMenu()
            //this is the code how the menu has the option to go back to the start.
        {
            Console.WriteLine("Do you want to go back to the menu? (Y/N)");
            string loop2Choice = Console.ReadLine();

            var loop = true;
            while (loop == true)
            {  //you can remove the {} and it will be fine without the break; after the menuCode();
                if (loop2Choice == "Y")
                {
                    menuCode();
                    break;
                }

                if (loop2Choice == "N")
                { 
                waitForKeyPress();
                break;

              }

           }               
            
        }
        
     public static void menuCode()
        {
            var loop = true;
            while (loop == true)
            //this is the loop
            {
                
                Console.WriteLine("Welcome to the menu!");
                Console.WriteLine();
                Console.WriteLine("Please type one of the following:");
                Console.WriteLine("New - Create a new profile");
                Console.WriteLine("Profiles - View the profile list");
                Console.WriteLine("Exit - Exit the menu");
                Console.WriteLine();

                Console.Write("What do you want to do? ");
                string menuchoice = (Console.ReadLine());

                if (menuchoice == "New")
                {
                    newUsers();
                    Console.WriteLine();
                    backToMenu();
                    break;

                }
                if (menuchoice == "Profiles")

                {
                    printListOfUsers();
                    Console.WriteLine();

                    backToMenu();
                    break;
                    
                }
               
                if (menuchoice == "Exit")
                {
                    waitForKeyPress();
                    break;

                }
             }

          }

      public static void waitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press key to close....");

            Console.ReadKey();
        }
    }

}
