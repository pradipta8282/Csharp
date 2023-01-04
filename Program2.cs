using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    
   
    
        class Program
        {
            static string[,] EmpDetails = new string[5, 3];
            static int[,] EmpSalary = new int[5, 7];
            public static void Main(string[] args)
            {
                input();
                showDetails();
            }
            public static void input()
            {
                //Console.WriteLine("Enter how many employess data you want to store");
                //  int a=Int32.Parse(Console.ReadLine());
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("enter emp code");
                EmpDetails[i, 0] = Console.ReadLine();
                    Console.WriteLine("enter empname");
                    EmpDetails[i, 1] = Console.ReadLine();
                    Console.WriteLine("enter contact number");
                    EmpDetails[i, 2] = Console.ReadLine();
                    EmpSalary[i, 0] = Int32.Parse(EmpDetails[i, 0]);
                    Console.WriteLine("Enter basics");
                    EmpSalary[i, 1] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter da");
                    EmpSalary[i, 2] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter hra");
                    EmpSalary[i, 3] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("enter tds");
                    EmpSalary[i, 4] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("gross salary is");
                    EmpSalary[i, 5] = getGrossSalary(EmpSalary[i, 1], EmpSalary[i, 2], EmpSalary[i, 3]);
                    int d = EmpSalary[i, 5];
                    Console.WriteLine(EmpSalary[i, 5]);
                    Console.WriteLine("NET SALARY IS");
                    EmpSalary[i, 6] = getNetSalary(EmpSalary[i, 4], d);
                    Console.WriteLine(EmpSalary[i, 6]);
                }
            }
            public static int getGrossSalary(int basics, int daa, int hraa)
            {
                return (basics + daa + hraa);
            }
            public static int getNetSalary(int tds, int d)
            {
                return (tds - d);
            }
            public static void showDetails()
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine($"Empcode:{EmpDetails[i, 0]}");
                    Console.WriteLine($"EmpName:{EmpDetails[i, 1]}");
                    Console.WriteLine($"empphone:{EmpDetails[i, 2]}");
                    Console.WriteLine($"empcode:{EmpSalary[i, 0]}");
                    Console.WriteLine($"basic:{EmpSalary[i, 1]}");
                    Console.WriteLine($"da:{EmpSalary[i, 2]}");
                    Console.WriteLine($"hra:{EmpSalary[i, 3]}");
                    Console.WriteLine($"tds:{EmpSalary[i, 4]}");
                    Console.WriteLine($"gross:{EmpSalary[i, 5]}");
                    Console.WriteLine($"netsalary:{EmpSalary[i, 6]}");
                    Console.WriteLine("-----------------------");
                }
                Console.ReadLine();
            }
        }
    }
