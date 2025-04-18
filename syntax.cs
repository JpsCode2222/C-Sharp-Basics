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

            // Math 
            /*
                Math.Max(10,20)
                Math.Min(10,30)
                Math.sqrt(10)
                Math.Round(10.0303)
            */

            // String
            string firstName = "happy";
            string lastName = "Sing";
            // concatination with interpolation 
            Console.WriteLine($"Full name is {firstName + lastName}");
            Console.WriteLine(firstName[0]);
            Console.WriteLine(firstName.SubString(3));
            Console.WriteLine(firstName.IndexOf('h'));
           
           // Conditional Statment
           int age = 23;
           if(age > 18){
            Console.WriteLine("Eligible for vote");
           }else{
            Console.WriteLine("Not eligible for vote");
           }


           string day = 3;
           if(day == 1){
            Console.WriteLine("Sunday");
           }
           else if(day == 2){
            Console.WriteLine("Monday");
           }
           else{
            Console.WriteLine("Weekend");
           }


        // switch
        int month = 2;
        switch(month){
            case 1:
                Console.WriteLine("January");
                break;
            
            case 2:
                Console.WriteLine("February");
                break;

            case 3:
                Console.WriteLine("March");
                break;

            default:
                Console.WriteLine("Not a valid month");
                break;
        }

        // Loops
        for(int i = 0; i < 11; i++){
            Console.WriteLine(i+1);
        }

        int i = 0;
        while(i < 11){
            Console.WriteLine(i+1);
            i++;
        }

        int j = 0;
        do{
            Console.WriteLine(i+1);
            i++;
        }while(i<11);

        // continue : skip the current execution
        // break : stop the overall execution

        

        }
    }
}
