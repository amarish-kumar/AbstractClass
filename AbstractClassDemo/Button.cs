using System;

namespace AbstractClassDemo
{
    public class Button : PaintControls
    {
        public string ButtonName { get; set; }

        public Button(int top, int bottom, int left, int right, string buttonName)
            : base(top, bottom, left, right)
        {
            ButtonName = buttonName;
        }
        public override void drawObject()
        {
            Console.WriteLine("Drawing object using button: " + ButtonName);
        }
    }
}
