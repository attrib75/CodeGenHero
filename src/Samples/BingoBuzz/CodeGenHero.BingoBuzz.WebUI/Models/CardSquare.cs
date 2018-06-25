using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGenHero.BingoBuzz.WebUI.Models
{
    public class CardSquare
    {
        public int xLocation { get; set; }

        public int yLocation { get; set; }

        public bool IsSelected { get; set; }

        public string Text { get; set; }


        public CardSquare(int xLocation, int yLocation, string text) 
            : this(xLocation, yLocation, text, false)
        {

        }

        public CardSquare(int xLocation, int yLocation, string text, bool isSelected)
        {
            this.xLocation = xLocation;
            this.yLocation = yLocation;
            this.Text = text;
            this.IsSelected = isSelected;
        }


    }
}
