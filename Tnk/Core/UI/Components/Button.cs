using SFML.Graphics;
using Tnk.Generics;

namespace Tnk.Core.UI
{
    internal class Button : Panel
    {
        public Text text { get; private set; }
        public Font font { get; private set; }
        public Color fontColor { get; private set; }
        public string displayedString { get; private set; }
        public uint fontSize { get; private set; }

        private string path = "C:/Users/sjame/Source/Repos/SjamesE/Tnk/Tnk/Assets/Dongle-Regular.ttf";

        public Button(UIObject parent) : base(parent)
        {
            fontSize = 32;
            fontColor = Color.Black;
            font = new Font(path);
            displayedString = "This is a Button";
            text = new Text(displayedString, font);
            text.FillColor = fontColor;
            text.DisplayedString = displayedString;
            text.CharacterSize = fontSize;
            text.Position = parent.transform.position.ToSFMLVector2f;
            Update();
        }

        private void Update()
        {
            text.FillColor = fontColor;
            text.CharacterSize = fontSize;
            text.DisplayedString = displayedString;
            Vector2i textSize = new Vector2i((int)text.GetGlobalBounds().Width, (int)text.GetGlobalBounds().Height);
            Vector2i newTextPos = center - (textSize / 2) - new Vector2i(0, (int)fontSize / 2 + (int)fontSize / 20);
            text.Position = newTextPos.ToSFMLVector2f;
        }

        public override void Draw(RenderWindow window)
        {
            base.Draw(window);

            window.Draw(text);
        }

        #region Setters
        public void SetDisplayString(string displayedString)
        {
            this.displayedString = displayedString;
            Update();
        }

        public void SetFontColor(Color color)
        {
            fontColor = color;
            Update();
        }

        public void SetFontSize(uint size)
        {
            fontSize = size;
            Update();
        }
        #endregion
    }
}
