using System;
using System.Collections.Generic;

namespace Inheritance_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task task = new Task();
                task.DoTask();   
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
