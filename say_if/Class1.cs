using System;
using System.Collections.Generic;
using System.Text;

namespace say_if
{
    public class Animal
    {
        public string name;
        public int legs;

        public void Sound( string sound)
        {
            Console.WriteLine(sound);

        }
        public void move(string move)
        {
            Console.WriteLine("I am " + move + "ing! ");
        }

    }
}
