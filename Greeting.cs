using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberChatBot
{
    internal class Greeting 
    {
        //public static void PlayVoiceGreeting()
        //{
        //    try
        //    {
        //        SoundPlayer player = new SoundPlayer("greeting.wav");
        //        player.PlaySync(); // Play audio synchronously

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Error playing audio: " + e.Message);
        //    }
        //}
        public static void AskUserName()
        {

            AnimatedText("Hi there I'm Pupet, What's your name & Welcome to the Cyber Security Awareness Bot!", 30);
            Console.ResetColor();
            string name = Console.ReadLine(); 
            if (string.IsNullOrWhiteSpace(name)) 
            {
                name = "Friend"; 
            }

            AnimatedText($"\nHello, {name}! Let's learn about cyber security.\n", 30);
            Thread.Sleep(500);
        }
        static void AnimatedText(string text, int delay = 40)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
        }
    }
}
