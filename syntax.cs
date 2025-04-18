using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write('String') : write statement withought end with line
            Console.Write("hello world");

            // Console.WriteLine('String') : write statement end with line
            Console.WriteLine("hello world");

            Console.ReadLine();


            // ---------------------------------------------------------------------
            // comments : single line 
            /* multiline 
               comments
            */


            // Datatype int : concate myAge variable to String and print using Console.Write()
            int myAge = 23;
            Console.Write("My age is : " + myAge);


            // Data types : int , float , char , bool , string
            int age = 23;               // 4 byte
            float price = 10.00f;       // 4 byte
            char initial = 'J';         // 2 byte
            bool isGreat = true;        // 1 bit
            string name = "user1";      // 2 byte per char

            // Operators
            /*
                1. Assignment + - * / %
                2. Logical && || !
                3. Comparision == != < > <= >=
            */
           
        }
    }
}
