using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp2;
using NameCheck;
using PlayerClass;

namespace ConsoleApp1
{
   
     

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green; //I change the output colors 
                                                         // so setting them to green here 
                                                        //  prevents them not matching later.
            Console.WriteLine("What is your name stranger?");

            Character.Name=StringValidator.ConsoleUserInputChecker(Console.ReadLine()); // this validates input as string  
            Console.WriteLine("Well met " + Character.Name);                          // &
                                                                                      //Sets Character.Name.

            var guiPlayerClass = new CharacterClassCreator();
            var guiPlayerAttribute = new CharacterAttributeAllocator();



            guiPlayerClass.ShowDialog();//This opens the GUI on your screen.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are: " + Character.Name+ " the adventuring "+ Character.Class+".");

            guiPlayerAttribute.ShowDialog();


            Console.ReadLine(); // causes pause to read console.



            // Testing:
            // Console.WriteLine(Character.Class);
            // Console.WriteLine(Character.Name);

        }






    }
}


