using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong.Pieces.Heads
{
    // Base Class
    // Abstract classes can't be instantiated
    // Abstract classes are made to be inherited from
    abstract class Head
    {
        public Color EyeColor { get; set; }
        public string Eyewear { get; set; }


        // no implementation, only allowed on abstract classes
        public abstract void Greet();

        public void Talk(string wordsToSay)
        {
            Greet();
            Console.WriteLine($"The {GetType().Name} says: '{wordsToSay}'");
        }
    }
}
