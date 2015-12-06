using System;

namespace AbstractClassDemo
{
    public abstract class PaintControls
    {
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Left { get; set; }
        public int Right { get; set; }

        //Initializing the values in ctor 
        public PaintControls(int top, int bottom, int left, int right)
        {
            Top = top;
            Bottom = bottom;
            Left = left;
            Right = right;
        }

        //Default ctor just to initialize default values if nothing supplied
        public PaintControls()
            : this(0, 0, 0, 0)
        { }

        //Creating abstract method, which needs to get overriden in derived class
        //This will not have any body just a signature with semicolon
        public abstract void drawObject();

        public int returnRandomValue()
        {
            Random r = new Random();
            return r.Next();
        }
    }
}
