using System;
using System.Media; // For playing WAV audio

namespace CyberAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav");
                player.PlaySync(); 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not play greeting audio. Error: " + ex.Message);
            }

           
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=======================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT     ");
            Console.WriteLine("=======================================");
            Console.ResetColor();

     
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

          
            Console.WriteLine($"Hello {userName}, welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I’m here to help you stay safe online.");

          
            Console.WriteLine("\nType a question (or 'exit' to quit):");
            string input;
            do
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                }
                else if (input.ToLower() == "how are you?")
                {
                    Console.WriteLine("I’m functioning perfectly, thank you for asking!");
                }
                else if (input.ToLower() == "what’s your purpose?")
                {
                    Console.WriteLine("My purpose is to teach you about cybersecurity awareness.");
                }
                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                }
                else
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                }

            } while (input.ToLower() != "exit");
        }
    }
}