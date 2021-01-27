using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong.Pieces.Legs
{
    class SpiderLegs : LegsBase
    {
        public SpiderLegs()
        {
            NumberOfLegs = 8;
            Shoes = "Rollerskates";
            Speed = 100;
            _musicGenre = "Bluegrass";
            Size = Size.Spider;
            Covering = "Hair";
        }

        public override void Dance()
        {
            Console.WriteLine("Spiders don't dance");
        }
    }
}
