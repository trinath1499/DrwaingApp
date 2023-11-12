namespace DrwaingApp.Widgets
{
    public class Ellipse : Widget
    {
        public double HorizontalDiameter { get; set; }
        public double VerticalDiameter { get; set; }

        public double Area
        {
            get
            {
                return Math.PI * HorizontalDiameter * VerticalDiameter;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) horizontalDiameter={HorizontalDiameter} verticalDiameter={VerticalDiameter} , Size={Area}");
        }
    }
}
