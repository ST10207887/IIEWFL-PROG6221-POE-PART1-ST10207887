using System;
using System.IO;
using System.Threading;
using NAudio.Wave;


namespace CyberAwarenessChatbot
{
    class Chatbot
    {
        private string userName;

        public void Start()
        {
            PlayGreeting();
            ShowLogo();
            AskName();
            WelcomeUser();
            ChatLoop();
        }

        private void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Assets.wav");

                if (File.Exists(audioPath))
                {
                    var audioFile = new AudioFileReader(audioPath);
                    var outputDevice = new WaveOutEvent();

                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    Console.WriteLine("Playing greeting audio...");
                  
                }
                else
                {
                    Console.WriteLine("Audio file not found at: " + audioPath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Could not play greeting audio. Error: " + ex.Message);
            }
        }



        private void ShowLogo()
        {
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
        }

        private void AskName()
        {
            Console.Write("\nPlease enter your name: ");
            userName = Console.ReadLine();
        }

        private void WelcomeUser()
        {
            TypeWriter($"\nHello {userName}, welcome to the Cybersecurity Awareness Bot!", ConsoleColor.Cyan);
            TypeWriter("I’m here to help you stay safe online.", ConsoleColor.Cyan);
        }

        private void ChatLoop()
        {
            Console.WriteLine("\n---------------------------------------");
            TypeWriter("Type a question (or 'exit' to quit):", ConsoleColor.Yellow);
            Console.WriteLine("---------------------------------------");

            string input;
            do
            {
                input = Console.ReadLine();
                HandleInput(input);
            } while (input.ToLower() != "exit");
        }

        private void HandleInput(string input)
        {
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
        }

        private void TypeWriter(string message, ConsoleColor color)
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Chatbot chatbot = new Chatbot();
            chatbot.Start();
        }
    }
}