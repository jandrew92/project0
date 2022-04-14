using System;

namespace StarMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Login.execute(); // log in before running program
            Menu.execute(); // run the options menu
            return; // exit the program
        }
    }
}
