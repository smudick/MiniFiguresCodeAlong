using System;
using LegoMiniFigures_CodeAlong.Pieces;
using LegoMiniFigures_CodeAlong.Pieces.Heads;


namespace LegoMiniFigures_CodeAlong
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;


            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new Skull
            { 
                Color = Color.Red,
                Condition = Condition.OnFire,
                EyeColor = Color.Black,
                Eyewear = "Aviators" 
            };

            var heads = new Head[] { coolHead, nerdHead, skull };

            foreach (var head in heads)
            {
                head.Talk("Where's the rest of my body?!?!");
            }
        }
    }
}
