using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong.Pieces.Heads
{
    class Skull : Head
    {
        public Condition Condition { get; set; }
        public Color Color { get; set; }

        public void Wail()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The Flaming {Color} Skull with {EyeColor} eyes wails angrily because it is Nicholas Cage.");
            }
            else
            {
                Console.WriteLine($"The {Color} skull with {EyeColor} wails mournfully because it is dead and {Condition} and not on fire.");
            }
        }
        public override void Greet()
        {
            if (Condition == Condition.OnFire)
            {
                Console.WriteLine($"The flaming skull smoulders in your direction");
            }
            else
            {
                Console.WriteLine("The skull says 'Howdy!'");
            }
        }
          
    }
}
