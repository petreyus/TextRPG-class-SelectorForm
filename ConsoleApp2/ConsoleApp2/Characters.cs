using System;

namespace PlayerClass
{

    public class Character
    {

      
        public static string Name { get; set; } = "";
        public static string Class { get; set; } = "";
        // private int Attack { get; set; } = rnd.Next(1, 100);
        public void AdventClass()
        {


        }
        
        public void ATK()
        {
            Random rnd = new Random();
            int Attack = rnd.Next(1, 100);
            Console.WriteLine("your attack is:"+ @Attack);
            




        }


        public static void HP()
        {
            Console.WriteLine("Input your health");
            string hp = Console.ReadLine();
            Console.WriteLine("your hp is:" + hp);
            



        }

    }


}




