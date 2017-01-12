using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static List<Person> people;

        static void Main(string[] args)
        {

            if (people == null)
            {
                people = new List<Person>();

                {

                }
            }

            menuCode();
            //newUsers();
            //printListOfUsers();
         //   waitForKeyPress();

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
          
           
        }
           


        static void printListOfUsers()
        {
            //interates through the people list and print's their details.
            foreach (var person in people)
            {
                Console.WriteLine(string.Format("{0} {1} was born on the {2} and they are {3} years old.",
                    person.Firstname, person.Surname, person.Dob.ToString("dd/MM/yyyy"), person.Age));

            }
        }
        

                
        static void menuCode()

        {
            { 
            var loop = true;
            while (loop == true)

            {
                Console.WriteLine();
                Console.WriteLine("Welcome to the menu!");
                Console.WriteLine("Type one of the following:");
                Console.WriteLine();
                Console.WriteLine("New - Create New Profile ");
                Console.WriteLine("Profiles - Print List of Profiles ");
                Console.WriteLine("Exit - Exit Program ");
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Enter choice: ");

                string menuchoice = (Console.ReadLine());


                if (menuchoice == "New")
                {
                    newUsers();
                    printListOfUsers();

                }


                if (menuchoice == "Profiles")
                {
                    printListOfUsers();

                }

                if (menuchoice == "Exit")

                {
                    waitForKeyPress();
                        break;
                }
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


