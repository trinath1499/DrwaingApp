namespace DrwaingApp.Widgets
{
    public class Rectangle : Widget
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public override void Draw()
        {
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) height={Height} width={Width} , Size={Area}");
        }
    }
}
