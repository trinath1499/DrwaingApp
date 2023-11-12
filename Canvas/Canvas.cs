using DrwaingApp.Interfaces;

namespace DrwaingApp.Canvas
{
    public class Canvas
    {
        private List<IWidget> widgets = new List<IWidget>();

        public void AddWidget(IWidget widget)
        {
            widgets.Add(widget);
        }

        public void DrawCanvas()
        {
            foreach (var widget in widgets)
            {
                widget.Draw();
            }
        }
    }
}
