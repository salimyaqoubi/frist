using System;
using System.Globalization;

namespace tasl1
{
    internal class Program
    {
        static void Main()
        {
            /*
                        #region Q1

                        // Get user input for a number
                        Console.Write("Enter a number: ");
                            string number = Console.ReadLine();
                            Console.WriteLine("You entered: " + number);
                        #endregion


                        #region Q2
                        Console.WriteLine("Enter Number: ");
                        int num = int.Parse(Console.ReadLine());
                        if (num % 12 == 0 && num % 9 == 0)
                            Console.WriteLine("yes");
                        else
                            Console.WriteLine("no");
                        #endregion


                        #region Q3
                        Console.WriteLine("Enter the First Number:  ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the seconed Number: ");
                        int num2 = int.Parse(Console.ReadLine()); 
                        int maxNum;

                        if (num1 > num2)
                        {
                            maxNum = num1;
                        }
                        else
                        {
                            maxNum = num2;
                        }
                        Console.WriteLine("The Maximum number is: " +maxNum);
                        #endregion


                        #region Q4
                        Console.WriteLine("Enter the Number: ");
                        string input = Console.ReadLine(); 

                        if (int.TryParse(input, out int number)) 
                        {
                            if (number < 0)
                            {
                                Console.WriteLine("Negative");
                            }
                            else
                            {
                                Console.WriteLine("positive");
                            }
                        }
                        #endregion


                        #region Q5
                        Console.WriteLine("Enter the First Number: ");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter the second Number: ");
                        int num2 = int.Parse(Console.ReadLine());  

                        Console.WriteLine("Enter the third Number: ");
                        int num3 = int.Parse(Console.ReadLine());

                        int max = Math.Max(Math.Max(num1, num2), num3);
                        int min = Math.Min(Math.Max(num1, num2), num3);

                        Console.WriteLine($"Maximum element: {max}");
                        Console.WriteLine($"Minimum element: {min}");

                        #endregion

                        #region Q6
                        Console.Write("Enter an integer number: ");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine((y % 2 == 0) ? "Even" : "Odd");
                        #endregion

                        #region Q7
                        List<char> chars = new List<char> { 'a', 'o', 'i', 'y', 'u' };
                        Console.WriteLine("Enter a character to check if its vowel or consonent: ");
                        Console.WriteLine((chars.Contains(char.Parse(Console.ReadLine()))) ? "vowel" : "Consonent");
                        #endregion

                        #region Q8
                        Console.Write("Enter number: ");
                        int flag = int.Parse(Console.ReadLine());
                        for (int i = 0; i < flag + 1; i++)
                        {
                            Console.Write(i);
                            Console.Write(',');
                        }
                        #endregion

                        #region Q9
                        Console.Write("Enter number: ");
                        int numberQ9 = int.Parse(Console.ReadLine());
                        for (int i = 0; i < 13; i++)
                        {
                            Console.Write(numberQ9 * i);
                            Console.Write(' ');
                        }
                        #endregion


                        #region Q10
                        Console.Write("Enter number: ");
                        int numberQ10 = int.Parse(Console.ReadLine());
                        for (int i = 1; i < numberQ10; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine(i);
                            }
                        }
                        #endregion

                        
            #region Q11

            Console.Write("Enter the base: ");
            int baseNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the exponent: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            // Calculate and print the result
            double result = Math.Pow(baseNumber, exponent);
            Console.WriteLine($"{baseNumber} ^ {exponent} = {result}");


            #endregion
            

            #region Q12

            int[] mark = new int[5];
            Console.WriteLine("Enter marks of 5 subjects: ");
            for (int i = 0; i<5; i++)
            {
                Console.Write("Subject {0} - ", i + 1);
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total=0, per;
                for(int i=0;i<5;i++)
            {
                total = total + mark[i];
            }
                per = total / 5;

            Console.WriteLine("Total Marks {0}", total);
            Console.WriteLine("Percentage {0}", per);
            Console.ReadLine();

            #endregion

            
            #region Q13

            Console.Write("Month number: ");
            int monthNumber = int.Parse(Console.ReadLine());

            int daysInMonth = GetDaysInMonth(monthNumber);

            if (daysInMonth != -1)
            {
                Console.WriteLine($"Days in month {monthNumber}: {daysInMonth}");
            }
            else
            {
                Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
            }
        }

        static int GetDaysInMonth(int month)
        {
            switch (month)
            {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: // December
                    return 31;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    return 30;
                case 2: // February
                    return 28;
                default:
                    return -1; // Invalid month number

            }

            #endregion

            */

            #region Q14

            string[] subject = { "Physics", "Chemistry", "Biology", "Mathematics", " Computer" };
            double[] mark = new double[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter Five marks of {subject[i]}");
                switch (subject[i])
                {
                    case "Physics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Chemistry":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Biology":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Mathematics":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    case "Computer":
                        mark[i] = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList().Average();
                        break;
                    default:
                        Console.WriteLine("Inavalid Input");
                        break;

                        #endregion

                }
            }
    }
}