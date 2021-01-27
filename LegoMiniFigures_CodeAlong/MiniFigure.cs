using LegoMiniFigures_CodeAlong.Pieces.Heads;
using LegoMiniFigures_CodeAlong.Pieces.Torsos;
using LegoMiniFigures_CodeAlong.Pieces.Legs;
using System;
using System.Collections.Generic;
using System.Text;

namespace LegoMiniFigures_CodeAlong
{
    class MiniFigure
    {
        public Head Head { get; }
        public Torso Torso { get; }
        public LegsBase Legs { get; }
        public string Name { get; }

        public MiniFigure(Head head, Torso torso, LegsBase legs, string name)
        {
            Head = head;
            Torso = torso;
            Legs = legs;
            Name = name;
        }

        public void MeetSomeone()
        {
            Console.WriteLine($"{Name} is starting the greeting process.");
            Legs.Walk();
            Torso.Wave();
            Head.Greet();
            Console.WriteLine(new string('-', 40));
        }

    }
}
