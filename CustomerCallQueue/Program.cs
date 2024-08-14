using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCallQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LListQueue callQueue = new LListQueue();
            int callerId = 1;
            int input = 0;
            while (input != 4)
            {
                Console.WriteLine("1: View current call queue | 2: Add customer to queue | 3: Remove customer to queue | 4: Exit");
                input = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (input)
                {
                    case 1:
                        callQueue.Display();
                        break;
                    case 2:
                        Console.Write("Enter the customer name: ");
                        string name = Console.ReadLine();
                        callQueue.Enqueue(callerId, name);
                        callerId++;
                        break;
                    case 3:
                        callQueue.Dequeue();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
