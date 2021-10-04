using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WeeklyAssignment_4_Qn_1
{
    class ThreadGo
    {
        public void AllThreads()
        {
            Thread t1 = new Thread(() => { Thread1(); });
            Thread t2 = new Thread(() => { Thread2(); });
            Thread t3 = new Thread(() => { Thread3(); });

            t1.Start();
            t2.Start();
            t3.Start();
        }

        public void Thread1()
        {
            Console.WriteLine("This is Thread 1");
        }

        public void Thread2()
        {
            Console.WriteLine("This is Thread 2");
        }

        public void Thread3()
        {
            Console.WriteLine("This is Thread 3");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            ThreadGo tg = new ThreadGo();
            
            Console.WriteLine("Choose any of the following option");
            Console.WriteLine("\n1. Create New Thread");
            Console.WriteLine("2. Destroy a Thread");
            Console.WriteLine("3. View Running Threads");
            Console.WriteLine("4. Run Thread Synchronously");
            Console.WriteLine("5. Make a Thread Sleep");
            Console.WriteLine("");

            int choose = int.Parse(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Choose which Thread to destroy");
                        Console.WriteLine("1. Thread 1");
                        Console.WriteLine("2. Thread 2");
                        Console.WriteLine("3. Thread 3");

                        int destroy = int.Parse(Console.ReadLine());
                        switch (destroy)
                        {
                            case 1:
                                {
                                    tg.AllThreads();
                                    
                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                case 3:
                    {
                        tg.AllThreads();
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Choose which Thread to sleep");
                        Console.WriteLine("1. Thread 1");
                        Console.WriteLine("2. Thread 2");
                        Console.WriteLine("3. Thread 3");
                        int sleep = int.Parse(Console.ReadLine());
                        switch (sleep)
                        {
                            case 1:
                                {
                                    tg.AllThreads();

                                    break;
                                }
                            case 2:
                                {
                                    break;
                                }
                            case 3:
                                {
                                    break;
                                }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }

                    
            }
            Console.ReadLine();


        }
    }
}
