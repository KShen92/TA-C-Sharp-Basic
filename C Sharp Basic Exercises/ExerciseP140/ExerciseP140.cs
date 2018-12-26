using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseP140
{
    class ExerciseP140
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.firstName = "Joe";
            emp1.lastName = "Smith";
            emp1.empID = 491234;

            Employee emp2 = new Employee();
            emp2.firstName = "Joenas";
            emp2.lastName = "Smiith";
            emp2.empID = 235982;

            Employee emp3 = new Employee();
            emp3.firstName = "Joenathan";
            emp3.lastName = "Smiiith";
            emp3.empID = 342964;

            Employee emp4 = new Employee();
            emp4.firstName = "Joehn";
            emp4.lastName = "Smiiiith";
            emp4.empID = 220589;

            Employee emp5 = new Employee();
            emp5.firstName = "Joe";
            emp5.lastName = "Savage";
            emp5.empID = 1;

            Employee emp6 = new Employee();
            emp6.firstName = "Joe";
            emp6.lastName = "Slick";
            emp6.empID = 2;

            Employee emp7 = new Employee();
            emp7.firstName = "Joe";
            emp7.lastName = "Sanchez";
            emp7.empID = 3;

            Employee emp8 = new Employee();
            emp8.firstName = "Rick";
            emp8.lastName = "Sanchez";
            emp8.empID = 4;

            Employee emp9 = new Employee();
            emp9.firstName = "Joehanas";
            emp9.lastName = "Smithers";
            emp9.empID = 34539;

            Employee emp10 = new Employee();
            emp10.firstName = "Alexxxxx";
            emp10.lastName = "Savannah";
            emp10.empID = 293429;

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            empList.Add(emp6);
            empList.Add(emp7);
            empList.Add(emp8);
            empList.Add(emp9);
            empList.Add(emp10);
            
            // List of Joe - foreach loop
            List<Employee> joeList = new List<Employee>();

            foreach (Employee currentEmp in empList)
            {
                if (currentEmp.firstName == "Joe")
                {
                    Employee joeEmp = new Employee();
                    joeEmp.firstName = currentEmp.firstName;
                    joeEmp.lastName = currentEmp.lastName;
                    joeEmp.empID = currentEmp.empID;
                    joeList.Add(joeEmp);
                }
            }
            foreach (Employee joeEmp in joeList)
            {
                Console.WriteLine(joeEmp.firstName + " " + joeEmp.lastName + " " + joeEmp.empID);
            }
            Console.ReadLine();

            // List of Joe - lambda
            List<Employee> joeLambdas = empList.Where(x => x.firstName == "Joe").ToList();
            foreach (Employee joeEmp in joeLambdas)
            {
                Console.WriteLine(joeEmp.firstName + " " + joeEmp.lastName + " " + joeEmp.empID);
            }
            Console.ReadLine();

            List<Employee> plusFives = empList.Where(x => x.empID > 5).ToList();
            foreach (Employee plusFiveEmp in plusFives)
            {
                Console.WriteLine(plusFiveEmp.firstName + " " + plusFiveEmp.lastName + " " + plusFiveEmp.empID);
            }
            Console.ReadLine();
        }
    }
}
