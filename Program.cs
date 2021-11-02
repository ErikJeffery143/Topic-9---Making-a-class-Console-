using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic_9___Making_a_class__Console_
{
    class Program
    {
        static void Main(string[] args)
        {

            Student person = new Student("Robert", "Ross");
            Console.WriteLine(person.firstName);
            person.firstName = "Bob";
            Console.WriteLine(person.firstName);
            Console.WriteLine(person.lastName);
            person.lastName = "Boss";
            Console.WriteLine(person.lastName);
            Console.WriteLine(person.StudentNumber);
            Console.WriteLine(person);
            Console.WriteLine(person.Email);
            Console.WriteLine("--------------------------------------------------------------------------");
            List<Student> students = new List<Student>();
            students.Add(new Student("Bob", "Ross"));
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter the Student's first name");
                string firstname = Console.ReadLine();

                Console.WriteLine("Student's last name.");
                string lastname = Console.ReadLine();

                students.Add(new Student(firstname, lastname));
            }
            for (int i = 0; i <=3; i++)
            {
                Console.WriteLine(students[i]);
            }



            Console.WriteLine("That's all folks, press ENTER to leave");
            Console.ReadLine();
        }
    }
}
