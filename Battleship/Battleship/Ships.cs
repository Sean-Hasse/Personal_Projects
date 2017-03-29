using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ships
    {
        // class will be used to construct all types of ships

        // attributes
        public int lives;
        public int hits;
        public bool alive;
        public int x;
        public int y;
        public int orientation;
        public string name;

        // constructor
        public Ships(int life, string nm)
        {
            lives = life;
            name = nm;
        }
        public Ships(int life, int xPos, int yPos, int orient, string nm)
        {
            lives = life;
            x = xPos;
            y = yPos;
            orientation = orient;
            name = nm;
            alive = true;
            hits = 0;
        }

        // properties
        public int Hits { get { return hits; } set { hits = value; } }
        public bool Alive { get { return alive; } set { alive = value; } }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        // methods
        // IsAHit will check an x and y given against the x and y of the ship, and pass true if it is a hit
        public bool IsAHit(int xPos, int yPos)
        {
            if (x == xPos && y == yPos)
                return true;
            else
                return false;
        }

        // GetHit will increase the hit counter and return false if the ship is destroyed by comparing hits to lives
        public bool GetHit()
        {
            hits++;
            if (hits > lives)
                return false;
            else
                return true;
        }
    }
}
