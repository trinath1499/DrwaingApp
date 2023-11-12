namespace DrwaingApp.Widgets
{

    public class TextBox : Rectangle
    {
        public ConsoleColor BackgroundColor { get; set; } = ConsoleColor.Red;
        public string Text { get; set; }

        public override void Draw()
        {
            Console.BackgroundColor = BackgroundColor;
            if (string.IsNullOrEmpty(Text))
            {                
                Console.WriteLine($"{Name} (x:{X}, y:{Y}) height={Height} width={Width} background={BackgroundColor} , Size={Area}");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"{Name} (x:{X}, y:{Y}) height={Height} width={Width} background={BackgroundColor} text={Text} , Size={Area}");
            }
            Console.ResetColor();

        }
    }
}
