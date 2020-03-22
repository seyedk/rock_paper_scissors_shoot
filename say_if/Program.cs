using System;

namespace say_if
{
    class Program
    {
        
        static int gimmeRandome()
        {
            Random r  = new Random();
            return r.Next(1,4);

        }
        static void Main(string[] args)
        {
            //var answer = "";
            //Animal dog = new Animal();
            //dog.Sound("woof woof ");
            //dog.move("walk");
            //Console.WriteLine("Please enter a key to continue");
            //Console.ReadKey();
            while (true)
            {
                Console.Write("Computer guessing, press space-bar when ready:");
                var key = Console.ReadKey();
                if (key.Key != ConsoleKey.Spacebar)
                    continue;
                var strReady = gimmeRandome();
               
                //System.Threading.Thread.Sleep(2500); 
                Console.WriteLine("hello to you!");
                if (strReady == 1)
                {
                    Console.WriteLine("You said Rock!");
                   
                   
                }

                if (strReady == 2)
                {
                    Console.WriteLine("You said Paper!");

                    
                }

                if (strReady == 3)
                {
                    Console.WriteLine("You said scissor!");

                   
                }
            }
           
            
        }
    }
}
