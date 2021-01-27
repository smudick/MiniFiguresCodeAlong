using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong.Pieces.Legs
{
    class RobotLegs : LegsBase
    {
        public RobotLegs()
        {
            Covering = "Metal";
            NumberOfLegs = 3;
            Speed = 4;
            _musicGenre = "Robo Boogie";
            Shoes = "No shoes";
            Size = Size.Giant;
        }
            public override void Dance()
        {
            Console.WriteLine($"The Robot legs dance the robot to {_musicGenre}");
        }
    }
}
