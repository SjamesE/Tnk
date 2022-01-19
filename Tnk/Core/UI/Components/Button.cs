using SFML.Graphics;

namespace Tnk.Core.UI
{
    internal class Button : Panel
    {
        public Text text { get; private set; }
        public string displayedString = "";

        public Button(UIObject parent) : base(parent)
        {
            
            text = new Text();
            text.DisplayedString = displayedString; 
        }

        //public void Draw(RenderWindow window)
        //{
        //
        //}

    }
}
