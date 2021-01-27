using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong.Pieces.Torsos
{
    class PirateTorso : Torso

    {
        public bool HasHook { get; private set; }
        public PirateTorso(bool hasHook)
        {
            HasHook = hasHook;
            Accessory = "Parrot";
        }
        public override void Wave()
        {
            if (HasHook)
            {
                Console.WriteLine("The pirate torso beckons menicingly with his hook.");
            }
            else
            {
                base.Wave();
                HasHook = true;
            }
        }
    }
}
