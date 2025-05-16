namespace DependencyDirection.Incorrect
{
    public class Translate
    {
        private readonly CharWriter writer;
        private readonly CharReader reader;

        public Translate()
        {
            writer = new CharWriter();
            reader = new CharReader();
        }

        public string TranslateText(string _text)
        {
            string text = reader.Read(_text);
            return writer.Write(text);
        }
    }
}