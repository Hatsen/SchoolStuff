using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bog
{
    class Bog
    {
        public Kapitel first;
        private string genre;

        public Bog(string genre)
        {
            this.genre = genre;
        }

        public void PrintBog()
        {

        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
    }
}
