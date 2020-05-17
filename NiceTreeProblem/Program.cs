using System;
using System.Collections.Generic;

namespace NiceTreeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables   

            short[] testCases = new short[19];
            var test = new List<string>();
            
            #endregion

            try
            {
                Console.WriteLine("Note: Input have to describe a Nice Tree nodes(N) and leaves(L) like in following example: (NLNLL) /n");
                Console.WriteLine("Enter number of test cases: ");

                int testsNumber = Convert.ToInt32(Console.ReadLine());


                if (testsNumber <= 20)
                {
                    for (int i = 0; i <= testsNumber - 1; i++)
                    {
                        Console.WriteLine("Enter an input: ");
                        test.Add(Console.ReadLine());
          
                       
                    }
                    
                }
                else throw new ArgumentOutOfRangeException();


                int depthNodes = new int();

                foreach (string x in test)
                {
                    try
                    {
                        if (x.Length <= 10000)
                            Console.WriteLine("case: " + x);

                        foreach (char n in x)
                        {
                            if (n.ToString().ToLower() == "n" && (n - 1).ToString().ToLower() == "n")
                            {
                                depthNodes++;
                            }
                        }


                        Console.WriteLine("depthNodes: " + depthNodes);
                    }

                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("The length of input have to be lower than 10 000.");
                    }


  
                };
                

            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The amount of test cases have to be under 20 times.");
            }

            Console.ReadKey();
        }
    }
}
