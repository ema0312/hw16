using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHuman    
    {
        public string _name { get; set; } 
        public int _hp { get; set; }
        public int _strenght { get; set; }
       
        //SuperHuman is a principal in a HS his power he is the strongest human. His goal to removed bullies from HS.
        public SuperHuman(int hp, string name, int strenght)
        {
         _name = name;
         _hp = hp;
         _strenght = strenght;
        }
    }
}
