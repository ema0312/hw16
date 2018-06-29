using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class AntiHero : SuperHuman
    {
        public int _life { get; set; }
        public string _reflex   { get; set; }


        public AntiHero(int hp, int life, int strenght, string name, string reflex) : base(hp, name, strenght)
        //AntiHero ability to react quicker than normal.  Her goal was to help anyone in trouble.
        {  
            _hp = hp;
            _life = life; 
            _strenght = strenght;
            _name = name;
            _reflex = reflex;

        }
    }
}
