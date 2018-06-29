using System.Diagnostics;
using System;

namespace myStory
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ProcessStartInfo theSuperHuman = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theSuperHuman.Arguments = "http://media.wizards.com/images/magic/daily/ur/2014/ur_wk09_289_cardart_heroofiroas.jpg";
            ProcessStartInfo theAntiHero = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theAntiHero.Arguments = "https://www.baka-tsuki.org/project/thumb.php?f=Ultimate_Antihero_V2_121.png&width=300";
            ProcessStartInfo theSuperVillain = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theSuperVillain.Arguments = "https://i.pinimg.com/236x/10/06/6b/10066b467c046f9c1312ef6cdcf0b66d--brown-hair-blue-eyes.jpg";
            ProcessStartInfo theSuperHero = new ProcessStartInfo("C:/Program Files (x86)/Google/Chrome/Application/Chrome.exe");
            theSuperHero.Arguments = "https://www.writeups.org/wp-content/uploads/Invisible-Woman-Ultimate-Marvel-Comics-Fantastic-Four-e.jpg";

            Console.WriteLine("About 2000 years there was a High School, name The Legion Academy.");
            Console.ReadKey();
            Console.WriteLine("The school principal was the world's strongest human.");
            Console.ReadKey();
            Process.Start(theSuperHuman);
            Console.ReadKey();
            Console.WriteLine("Every morning Principal stood by door and greeted all the students by their name.");
            Console.ReadKey();
 
            Console.WriteLine("but, one day it was contrary a new student asked what's your name");
            Console.ReadKey();
            Process.Start(theAntiHero);

            Console.Write("And the principal responded my name is [enter name] ");
            String shumanName = Console.ReadLine();

            SuperHuman aboutSuperHuman = new SuperHuman(15,shumanName,100);
            int Strenght = aboutSuperHuman._strenght;
            aboutSuperHuman._strenght = 100;

            Console.WriteLine("New student replied:  Good morning, {0} nice to meet you!",aboutSuperHuman._name);  
            Console.ReadKey();

            Console.WriteLine("{0}: What is your name? [enter name]", aboutSuperHuman._name);
            string newStudent = Console.ReadLine();

            Console.WriteLine ("{0}: My name is {0}.", newStudent);
            Console.WriteLine(" {0}: Welcome to the Legion Academy, Would you like me to pair you with a student to show you around?", aboutSuperHuman._name);
            Console.WriteLine("{0}: Sure, she glance at the motorcyclist whom wagg her gorgeous hair, and adjusted her leather gear.", newStudent);
            Console.ReadKey();

            Process.Start(theSuperVillain);

            Console.WriteLine(" {0}:Hi, Dalilah this is Speedy, Speedy this is Dalilah. Please give her a tour.", aboutSuperHuman._name);
            Console.ReadKey();
            Console.WriteLine("Speedy, had big EGO was very popular. Her high self-esteem was because her abilities to replicate and speed.");
            Console.ReadKey();
            Console.WriteLine("But, lately she was unhappy and plan to fight Deborah because she was becoming more popular. ");
            Console.ReadKey();

            Process.Start(theSuperHero);

            SuperVillain enemy = new SuperVillain(15, "Speedy", 10, 50, "duplication");
            int _speed = enemy._speed--;
            int _strenght = enemy._strenght--;

            Console.WriteLine("Speedy was ready to fight Deborah, new student jump and attack {0}", enemy._name);

            Console.WriteLine(" {0} total hits {1} and Supervillain speed is {2}", aboutSuperHuman._name, aboutSuperHuman._hp, enemy._strenght);
            Console.ReadKey();

            Console.WriteLine("Principal attempt to stop the fight, but speedy replicate many times.");
            Console.WriteLine("Then, jump to her motorcycle speed up and left the schoolground");
            Console.ReadKey();

            Console.WriteLine("Principal, new student and the Deborah were upset they lost. The end"); 
            Console.ReadKey();
       
        }
    }
}
