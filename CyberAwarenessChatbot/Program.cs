using System;
using System.Media;

namespace CyberAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SoundPlayer player = new SoundPlayer("Assets/Assets.wav");
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not play greeting audio. Error: " + ex.Message);
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

            Console.WriteLine($"\nHello {userName}, welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("I’m here to help you stay safe online.");

            Console.WriteLine("\nType a question (or 'exit' to quit):");
            string input;
            do
            {
                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine($"I didn’t quite understand that, {userName}. Could you rephrase?");
                }
                else if (input.ToLower() == "how are you?")
                {
                    Console.WriteLine($"I’m functioning perfectly, thank you for asking, {userName}!");
                }
                else if (input.ToLower() == "what’s your purpose?" || input.ToLower() == "what is your purpose?")
                {
                    Console.WriteLine($"My purpose is to teach you about cybersecurity awareness, {userName}.");
                }
                else if (input.ToLower() == "what can i ask you about?")
                {
                    Console.WriteLine($"You can ask me about phishing, strong passwords, suspicious links, and safe browsing tips, {userName}.");
                }
                else if (input.ToLower() == "tell me about phishing")
                {
                    Console.WriteLine($"Phishing is when attackers trick you into giving personal information by pretending to be trustworthy. Always check links and sender details carefully, {userName}.");
                }
                else if (input.ToLower() == "how do i make strong passwords?")
                {
                    Console.WriteLine($"Use at least 12 characters, mix uppercase, lowercase, numbers, and symbols. Avoid personal info like birthdays, {userName}.");
                }
                else if (input.ToLower() == "tips for safe browsing")
                {
                    Console.WriteLine($"Keep your browser updated, avoid clicking unknown links, and use secure websites with HTTPS, {userName}.");
                }
                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine($"Goodbye {userName}! Stay safe online.");
                }
                else
                {
                    Console.WriteLine($"I didn’t quite understand that, {userName}. Could you rephrase?");
                }

            } while (input.ToLower() != "exit");
        }
    }
}