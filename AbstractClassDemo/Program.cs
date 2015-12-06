
using System;

namespace AbstractClassDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            //This is also legal. We are creating a variable of paintcontrols and instantiating Button

            // PaintControls paintControls = new Button(11, 11, 11, 11, "Line");
            // Console.WriteLine(paintControls.returnRandomValue());
            // paintControls.drawObject();
            // Console.ReadLine();
            Button b = new Button(11, 11, 11, 11, "Line");
            b.drawObject();
            //We also called concrete method written in abstract class from derived class object.
            Console.WriteLine(b.returnRandomValue());
            Console.ReadLine();
        }
    }
}
