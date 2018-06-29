using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero : SuperHuman
    {
        public String _durability { get; set; }
        //fight the evil of his universe protect the public
        public string _teleportation  { get; set; }

        public SuperHero(String Elisa, int hp, int strenght, String durability, string teleportation) : base (hp, Elisa, strenght)
        //I am the superhero and have durability and Ability move from one place to another without occupyping the space in between 
        {
            _name = Elisa;
            _hp = hp;
            _strenght = strenght;
            _durability = durability;
            _teleportation = teleportation;
        }
    }
}
