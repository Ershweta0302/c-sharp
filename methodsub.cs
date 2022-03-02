using System;

namespace Method
{
    class Method
    {
        //method declearation
        static int subNum()
        {
            int sub = 50-10;
            return sub;
        }
        static void Main (String [] args)
        {
            int sub = subNum();
            
            Console.WriteLine(sub);
            
            Console.ReadLine();
        }
    }
}