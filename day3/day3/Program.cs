using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)

        {
           /// Random num = new Random();
           // int numTarget=num.Next(50,76);
           // int userGuess = 0;
           // int attempts = 0;

           // Console.WriteLine("===== Guessing Game =====");

           // while (userGuess != numTarget)
           // {
           //     Console.WriteLine("Guess a number between 50 and 75:");
           //     userGuess = Convert.ToInt32(Console.ReadLine());

           //     attempts++;
           //     if (userGuess < numTarget)
           //     {
           //         Console.WriteLine("Hint:Try a higher number");
           //     }
           //     else if (userGuess > numTarget)
           //     {
           //         Console.WriteLine("Hint: Try a lower number");
           //     }
           // }
           // int points = 0;
           // if (attempts == 1)
           // {
           //     points = 10;
           // }
           // else if (attempts == 2)
           // {
           //     points = 7;
           // }
           // else if (attempts == 3)
           // {
           //     points = 5;
           // }
           // else
           // {
           //     points = 0;
           // }
           // //Console.WriteLine("Congratulations!");
           // //Console.WriteLine("Your attempts: " + attempts);
           //// Console.WriteLine("Your points :" + points);


            ///>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>///

            string[] studnt = {"Ahmad", "Sara", "Omar", "Lina", "Yazan"};
            int[] Studentgrades = { 85, 92, 68, 75, 90 };
            int choice = 0;

            do
            {
                Console.WriteLine("\n===== School System =====");
                Console.WriteLine("1. Display Students");
                Console.WriteLine("2. Search for Student");
                Console.WriteLine("3. Check Student Result");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // عرض الأسماء
                        Console.WriteLine("\nStudents:");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine(studnt[i]);
                        }

                        // عرض العلامات
                        Console.WriteLine("\nStudentgrades:");
                        foreach (int g in Studentgrades) 
                        {
                            Console.WriteLine(g);
                        }
                        break;

                    case 2:
                        Console.Write("\nEnter student name: ");
                        string name = Console.ReadLine();

                        int index = 0;
                        bool isFound = false;

                        while (index < 5)
                        {
                            if (studnt[index] == name) // مقارنة بسيطة ومباشرة
                            {
                                Console.WriteLine("Student Found!");
                                isFound = true;
                                break;
                            }
                            index++;
                        }

                        if (!isFound)
                        {
                            Console.WriteLine("Student Not Found.");
                        }
                        break;

                    case 3:
                        Console.Write("\nEnter grade: ");
                        int mark = Convert.ToInt32(Console.ReadLine());

                        // شروط سريعة ومباشرة
                        if (mark >= 90)
                            Console.WriteLine("Excellent");
                        else if (mark >= 80)
                            Console.WriteLine("Very Good");
                        else if (mark >= 70)
                            Console.WriteLine("Good");
                        else if (mark >= 60)
                            Console.WriteLine("Pass");
                        else
                            Console.WriteLine("Fail");
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                }

            } while (choice != 4);





        }
    }
}
