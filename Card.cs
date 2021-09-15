using System;
using System.Collections.Generic;
using System.Text;

namespace StudentCards
{
    class Card
    {
        private int value;
        private String color;

        /// <summary>
        /// value 2 - 14
        /// color: diamond, club, heart, spade
        /// </summary>
        /// <param name="value"></param>
        /// <param name="color"></param>
        public Card(int value, String color)
        {
            this.value = value;
            this.color = color;
        }
        public int Value
        {
            get
            {
                return value;
            }
        }
        public String Color
        {
            get
            {
                return color;
            }
        }


        public override String ToString()
        {
            String text = Color + " ";
            if (Value < 11)
            {
                text += Value;
            }
            else if (Value == 11)
            {
                text += "J";
            }
            else if (Value == 12)
            {
                text += "D";
            }
            else if (Value == 13)
            {
                text += "K";
            }
            else if (Value == 14)
            {
                text += "A";
            }
            return text;
        }
    }
}
