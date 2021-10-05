using System;
using HouseFunction;
//comment testing
/*
long comment testing
    we use PascelCase for the most part and that means artifacts as EverythingWillBeCapitilized
        this is used primarily for classes 
    we use camelCase for naming field that means naming artfiacts as onlyOnceYouHaveALowerCaseWordAtTheBeginning
        this is used primarily for 
*/


namespace Helloworld
{
    class Program
    {
        /*
            -Main method is the first method that will be called/run. (The compiler will look for ths method)
            -static means, I don't have to instantiate the program class to use that method
            -Void, the method will not give anything back
        */
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello World!");

            //This is if you don't make the method static you have to instantiate it
            //Program test = new Program(); //This will instantiate the obj
            //test.Example();

            Program.Example();

            House Stephen = new House();
            Stephen.MiceName = "Jerry";
            Console.WriteLine(Stephen.MiceName);
            */
            Console.WriteLine("Type your name");
            string s = Console.ReadLine();

            Console.WriteLine("Hello "+s);

        }
        public static void Example(){}

    }
}
