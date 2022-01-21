using SFML.Graphics;

namespace Tnk.Core.UI
{
    internal class Button : Panel
    {
        public Text text { get; set; }
        public Font font { get; set; }
        public string displayedString { get; set; }
        private string path = "C:/Users/jsovea/source/repos/SjamesE/Tnk/Tnk/Assets/Dongle-Regular.ttf";

        public Button(UIObject parent) : base(parent)
        {
            font = new Font(path);
            displayedString = "test";
            text = new Text(displayedString, font);
            text.DisplayedString = displayedString; 
        }

        private void Update()
        {

        }

        public override void Draw(RenderWindow window)
        {
            base.Draw(window);

            Update();
            window.Draw(text);
        }
    }
}
