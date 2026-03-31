using System;
using System.Media;
using System.Threading;

namespace CyberAwarenessChatbot
{
    class Program
    {
        static void TypeWriter(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets/Assets.wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                TypeWriter("Could not play greeting audio. Error: " + ex.Message, ConsoleColor.Red);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("   ██████╗   █████╗   ██████╗ ");
            Console.WriteLine("  ██╔═══██╗ ██╔══██╗ ██╔═══██╗");
            Console.WriteLine("  ██║   ██║ ███████║ ██║   ██║");
            Console.WriteLine("  ██║   ██║ ██╔══██║ ██║   ██║");
            Console.WriteLine("  ╚██████╔╝ ██║  ██║ ╚██████╔╝");
            Console.WriteLine("   ╚═════╝  ╚═╝  ╚═╝  ╚═════╝ ");
            Console.WriteLine("             CAC              ");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT   ");
            Console.ResetColor();


            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();

            TypeWriter($"\nHello {userName}, welcome to the Cybersecurity Awareness Bot!", ConsoleColor.Cyan);
            TypeWriter("I’m here to help you stay safe online.", ConsoleColor.Cyan);

            Console.WriteLine("\n---------------------------------------");
            TypeWriter("Type a question (or 'exit' to quit):", ConsoleColor.Yellow);
            Console.WriteLine("---------------------------------------");

            string input;
            do
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    TypeWriter($"I didn’t quite understand that, {userName}. Could you rephrase?", ConsoleColor.Red);
                }
                else if (input.ToLower() == "how are you?")
                {
                    TypeWriter($"I’m functioning perfectly, thank you for asking, {userName}!", ConsoleColor.Green);
                }
                else if (input.ToLower() == "what’s your purpose?" || input.ToLower() == "what is your purpose?")
                {
                    TypeWriter($"My purpose is to teach you about cybersecurity awareness, {userName}.", ConsoleColor.Green);
                }
                else if (input.ToLower() == "what can i ask you about?")
                {
                    TypeWriter($"You can ask me about phishing, strong passwords, suspicious links, and safe browsing tips, {userName}.", ConsoleColor.Cyan);
                }
                else if (input.ToLower() == "tell me about phishing")
                {
                    TypeWriter($"Phishing is when attackers trick you into giving personal information by pretending to be trustworthy. Always check links and sender details carefully, {userName}.", ConsoleColor.Yellow);
                }
                else if (input.ToLower() == "how do i make strong passwords?")
                {
                    TypeWriter($"Use at least 12 characters, mix uppercase, lowercase, numbers, and symbols. Avoid personal info like birthdays, {userName}.", ConsoleColor.Yellow);
                }
                else if (input.ToLower() == "tips for safe browsing")
                {
                    TypeWriter($"Keep your browser updated, avoid clicking unknown links, and use secure websites with HTTPS, {userName}.", ConsoleColor.Yellow);
                }
                else if (input.ToLower() == "exit")
                {
                    TypeWriter($"Goodbye {userName}! Stay safe online.", ConsoleColor.Green);
                }
                else
                {
                    TypeWriter($"I didn’t quite understand that, {userName}. Could you rephrase?", ConsoleColor.Red);
                }

            } while (input.ToLower() != "exit");
        }
    }
}