namespace Curs20
{
    public class TextBox
    {
        public string Text { get; set; }
        public string Font { get; set; }
        public bool Bold { get; set; }
        public string Color { get; set; }
    }

    public class TextBoxBuilder
    {
        TextBox textBox;

        private string text;
        private string font;
        private bool bold;
        private string color;

        public TextBoxBuilder SetText(string text)
        {
            this.text = text;
            return this;
        }

        public TextBoxBuilder SetFont(string font)
        {
            this.font = font;
            return this;
        }

        public TextBoxBuilder SetBold(bool bold)
        {
            this.bold = bold;
            return this;
        }

        public TextBoxBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public TextBox Build()
        {
            textBox = new TextBox();
            textBox.Text = text;
            textBox.Font = font;
            textBox.Bold = bold;
            textBox.Color = color;
            return textBox;
        }
    }

    public class TextBoxClient
    {
        public TextBoxClient()
        {
            TextBox textBox = new TextBox();
            textBox.Text = "Hello";
            textBox.Font = "Arial";
            textBox.Bold = true;
            textBox.Color = "Red";
        }
    }

    public class TextBoxClient2
    {
        public TextBoxClient2()
        {
            TextBoxBuilder textBoxBuilder = new TextBoxBuilder();

            var textBox = textBoxBuilder.SetText("Hello")
                 .SetFont("Arial")
                 .SetBold(true)
                 .SetColor("Red")
                 .Build();
        }
    }
}
