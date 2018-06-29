using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain : SuperHuman
    {
        //SuperVillain Alias was Speedy. She was  a popular and had big EGO. Her ability to create physical duplicates of self
        // Move,run, fly, react , think and sense at speeds. Her goal was to destroy anyone that got on her way. Always won.
        public int _speed { get; set; }
        public string _duplication { get; set; } 

        public SuperVillain(int hp, string Speedy, int strenght,int speed, string duplication) : base(hp, Speedy, strenght)
        {
            _hp = hp;
            _name = Speedy;
            _strenght = strenght;
            _speed = speed;
            _duplication = duplication;
        }
            public void damage(int _hp)
            {
                if (_speed == 15)
                {
                    Console.WriteLine("you are good pursue catch and attack");

                }
                else if (_speed <= 0)
                {
                    Console.WriteLine("Can replicate longer you are dead");

                }
                else
                {
                    Console.WriteLine("proceed");
                }

            }
        }
}
