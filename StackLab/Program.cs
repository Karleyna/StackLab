using System;
using StackLib;

namespace StackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            MyStack<int> a = new MyStack<int>();
            
                for (int i = 0; i < 3; i++)
                {

                    a.Push(r.Next(10, 25));

                }
                a.Show();
           
            for (; ; )
            {
                Console.WriteLine("Enter count:\n1.Push elem\n2.Pop elem\n3.Push stack\n4.Pop stack\n5.Show stack\n6.-123 to exit");
                int x = Convert.ToInt32(Console.ReadLine());
                if ( x == -123) {
                    break;
                }
                int y;
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Enter count\n");
                        y = Convert.ToInt32(Console.ReadLine());
                        a.Push(y);
                        a.Show();
                        break;
                    case 2:
                        a.Pop();
                        a.Show();
                        break;
                    case 3:
                        MyStack<int> b = new MyStack<int>();

                        for (int i = 0; i < 3; i++)
                        {

                            b.Push(r.Next(1, 45));

                        }
                        b.Show();
                        a.Push_stack(b);
                        a.Show();
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter count deleted items: ");
                            int countItems = Convert.ToInt32(Console.ReadLine());
                            a.Pop_stack(countItems);
                        }

                        break; 
                }
            }

            
        }
        
    }
}
