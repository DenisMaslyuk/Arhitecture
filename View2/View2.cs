using System;
using BL;
using Model;

namespace View2
{
    
    class View2
    {
        static void Main(string[] args)
        {
            Logic logic = new Logic();
            foreach (Employee user in logic.GetDataDap())
            {
                Console.WriteLine(user.Name);
            }
            Console.ReadKey();
        }
    }
}
