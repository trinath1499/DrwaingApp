using DrwaingApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrwaingApp.Widgets
{
    public abstract class Widget : IWidget
    {
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Draw();

    }
}
