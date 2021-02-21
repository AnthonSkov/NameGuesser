using System;

namespace Guesser_exercise
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Please enter name. You have 3 tries. First letter must be capital");
            
            int Tries = 3;

            string CorrectName = "Allan";

            bool activeAccess = false;



            while (activeAccess == false)
            {

                String EnteredName = Console.ReadLine();

                if (EnteredName == CorrectName)
                {

                    activeAccess = true;
                    Console.WriteLine("Correct. Access granted");

                }

                else if (EnteredName != CorrectName)
                {
                    Tries--;
                    if(Tries >= 0)
                    {
                        Console.WriteLine("Incorrect. Tries left is " + Tries);
                    }
                    


                    if (Tries == 0)
                    {
                        Console.WriteLine("Initiate self-destruct sequence ");
                        activeAccess = true;
                    }
                    
                }
               



            }


            

















        }
    }
}
