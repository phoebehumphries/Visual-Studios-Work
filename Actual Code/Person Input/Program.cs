using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Input
{
    class Program
    {
        static List<Person> people;

        static void Main(string[] args)
        {

            if (people == null)
            {
                people = new List<Person>();
            }   //the list.

            menuCode();
            //this is the code that is being run.
           
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

        static void newUsers()
        {
            Person p0 = new Person();
            //creates new person, called p0.
            Console.WriteLine("What is your firstname?");
            string new_firstname = Console.ReadLine();
            //asks the question and sets what the user inputs as new_firstname.
            p0.Firstname = new_firstname;
            //This sets the user input as equal to the new person (p0) Firstname's
            Console.WriteLine("What is your surname?");
            string new_surname = Console.ReadLine();
            p0.Surname = new_surname;
            //same for surname
            Console.WriteLine("Please enter your date of birth in the form, dd/mm/yyyy");
            string new_dob = Console.ReadLine();
            //does the same but for date of birth.
            DateTime dt0 = Convert.ToDateTime(new_dob);
            //converting the new_dob to DateTime format.
            p0.Dob = (dt0);
            //setting the p0.Dob to the converted new_dob (aka dt0)
            people.Add(p0);
            //adding all of the p0 Person to the list. (appending it.)

            printListOfUsers();
            Console.WriteLine();

        }
        
        static void printListOfUsers()
        {
            //interates through the people list and print's their details.
            foreach (var person in people)
            {
                
                Console.WriteLine(string.Format("{0} {1} was born on the {2} and they are {3} years old.",
                    person.Firstname, person.Surname,
                    person.Dob.ToString("dd/MM/yyyy"), person.Age));
            }
        }
        static void menuCode()
        {
            var loop = true;
            while (loop == true)
                //loop, it always equals true therefore always run.
            {
                //this is the main text for the menu.
                Console.WriteLine("Welcome to the menu!");
                Console.WriteLine();
                Console.WriteLine("Please select one of the following:");
                Console.WriteLine("New - Create a new profile");
                Console.WriteLine("Profiles - View the profile list");
                Console.WriteLine("Exit - Exit the menu");
                Console.WriteLine();

                Console.Write("What do you want to do? ");
                string menuchoice = (Console.ReadLine());

                if (menuchoice == "New")
                //if the user types, "New" then the following code runs.
                {
                    newUsers();
                    Console.WriteLine();
                }
                if (menuchoice == "Profiles")

                {
                    createTestUsers();
                    printListOfUsers();
                    Console.WriteLine();
                }

                if (menuchoice == "Exit")
                {
                    waitForKeyPress();
                    break;
                    //breaks the loop after pressing the key.

                }
            }

        }

        static void waitForKeyPress()
        {
            Console.WriteLine();
            Console.WriteLine("Press Key to close...");

            Console.ReadKey();
        }
    }

}
