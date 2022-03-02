using System;

namespace Method
{
    class Method
    {
        //method declearation
        public void display ()
        {
            Console.WriteLine("Hello Sir");
        }
        static void Main (String [] args)
        {
            //creat  class onject
            Method M = new Method();
            //call the method
            M.display ();
            Console.ReadLine();

        }
    }
}