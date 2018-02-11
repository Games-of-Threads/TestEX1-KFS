using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEX1_KFS
{
    class TriangleIdentifier
    {
        public bool IsRunning { get; set; }

        int a, b, c;

        string state;

        public TriangleIdentifier()
        {
            state = "start";
            IsRunning = true;
        }

        public void Triangle()
        {
            switch (state)
            {
                case "start":
                    Console.Clear();
                    a = 0;
                    b = 0;
                    c = 0;
                    Console.WriteLine("welcome! please type your choice of action then press enter to continue\n a: starts the main purpose of the program.\n exit: closes down the application.");
                    state = Console.ReadLine(); ;
                    break;
                case "a":
                    Console.WriteLine("please insert the value of a");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        if (a <= 0)
                        {
                            InvalidReport();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        ErrorReport(state);
                        break;
                    }
                    Console.WriteLine("a's value is now {0} press enter to continue", a);
                    Console.ReadKey();
                    state = "b";
                    break;
                case "b":
                    Console.WriteLine("please insert the value of b");
                    try
                    {
                        b = int.Parse(Console.ReadLine());
                        if (b <= 0)
                        {
                            InvalidReport();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        ErrorReport(state);
                        break;
                    }
                    Console.WriteLine("b's value is now {0} press enter to continue", a);
                    Console.ReadKey();
                    state = "c";
                    break;
                case "c":
                    Console.WriteLine("please insert the value of c");
                    try
                    {
                        c = int.Parse(Console.ReadLine());
                        if (c <= 0)
                        {
                            InvalidReport();
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        ErrorReport(state);
                        break;
                    }
                    Console.WriteLine("c's value is now {0} press enter to continue", a);
                    Console.ReadKey();
                    state = "calculate";
                    break;
                case "calculate":
                    if (a != b && a != c)
                    {
                        if (b != c)
                        {
                            TriangleReport("Scalene", "all sides are different");
                        }
                        else
                        {
                            TriangleReport("isosceles", "2 sides are relative yet the last isn't");
                        }
                    }
                    else if (a == b || a == c)
                    {
                        if (b != c)
                        {
                            TriangleReport("isosceles", "2 sides are relative yet the last isn't");
                        }
                        else
                        {
                            TriangleReport("equilateral", "all sides are relative");
                        }
                    }
                    else
                    {
                        ErrorReport("calculation of triangles");
                    }
                    Console.ReadKey();
                    state = "start";
                    break;
                case "exit":
                    IsRunning = false;
                    break;
                default:
                    state = "start";
                    break;
            }
        }

        public void TriangleReport(string report, string reason)
        {
            Console.WriteLine("triangle is {0} since the side values of the triangle are a = {1} b = {2} c = {3} which means {4}",report,a,b,c,reason);
        }

        public void ErrorReport(string report)
        {
            Console.WriteLine("sorry sir we encountered a error in {0} resetting back to start, press enter to continue",report);
            Console.ReadKey();
            state = "start";
        }

        public void InvalidReport()
        {
            Console.WriteLine("sorry sir that input is invalid, resetting back to start, press enter to continue");
            Console.ReadKey();
            state = "start";
        }
    }
}
