using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrwaingApp.Widgets
{
    public class Circle : Widget
    {
        public double Radius { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) radius={Radius} , size={Area}");
        }
    }
}
