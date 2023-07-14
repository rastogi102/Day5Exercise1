using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConExercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numDays = int.Parse(Console.ReadLine());

            int[][] salaryArray = new int[numEmployees][];

            for (int i = 0; i < numEmployees; i++)
            {
                salaryArray[i] = new int[numDays];

                for (int j = 0; j < numDays; j++)
                {
                    Console.Write($"Enter the salary for day {j + 1} of employee {i + 1}: ");
                    salaryArray[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDay\t\tEmployee Salaries\t\tTotal Salary");

            for (int i = 0; i < numDays; i++)
            {
                int totalSalary = 0;

                Console.Write($"Day {i + 1}\t\t");

                for (int j = 0; j < numEmployees; j++)
                {
                    Console.Write($"{salaryArray[j][i]}\t");
                    totalSalary += salaryArray[j][i];
                }

                Console.WriteLine($"\t\t\t{totalSalary}");
            }

            Console.ReadLine();
        }
    }
}
