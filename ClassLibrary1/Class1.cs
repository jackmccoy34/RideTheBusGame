using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum color { Red = 1, Blue }
    public enum number { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }
    public class Card
    {
        public Card()
        {
            Number1 = rnd.Next(2, 15);
            ColorPicker = rnd.Next(1, 3);
        }
        enum color { }
        enum number { }
        public Random rnd = new Random();
        public int ColorPicker { get; private set; }
        public int Number1 { get; private set; }
        public string Color1
        {
            get
            {
                if (ColorPicker == 1)
                {
                    return "Red";
                }
                else
                {
                    return "Black";
                }
            }
        }
    }
    public class PrevCard1
    {
        public PrevCard1()
        {
            Number2 = rnd.Next(2, 15);
            ColorPicker = rnd.Next(1, 3);
        }
        enum color { }
        enum number { }
        public Random rnd = new Random();
        public int ColorPicker { get; private set; }
        public int Number2 { get; private set; }
        public string Color2
        {
            get
            {
                if (ColorPicker == 1)
                {
                    return "Red";
                }
                else
                {
                    return "Black";
                }
            }
        }
        public PrevCard1(int N1, int C1)
        {
            Number2 = N1;
            ColorPicker = C1;
        }

    }

}





