namespace DrwaingApp.Widgets
{
    public class Square : Widget
    {
        public int Side { get; set; }

        public double Area { get { return Side * Side; } }

        public override void Draw()
        {
            Console.WriteLine($"{Name} (x:{X}, y:{Y}) height={Side} width={Side} , Size={Area}");
        }
    }
}
