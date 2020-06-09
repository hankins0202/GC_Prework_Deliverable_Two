using System;

namespace GC_Deliverable_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Message Encoder");
            Console.WriteLine("What is your message?");
            string input = (Console.ReadLine()).ToUpper();
            //string upper = input.ToUpper();
            string message = "";
            int checksum = 0;
            //string test = "";



            //Encode string message to 
            foreach (char c in input)
            {

                int ch = ((int)c);
                //test += ch + "-";
                message += ch - 64 + "-";
                checksum += ch;

            }


            //Console.WriteLine(test);
            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    
    }
}
