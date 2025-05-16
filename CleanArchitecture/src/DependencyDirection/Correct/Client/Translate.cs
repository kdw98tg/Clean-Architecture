namespace DependencyDirection.Correct
{
    public class Translate
    {
        private readonly ICharWriter writer;
        private readonly ICharReader reader;

        public Translate()
        {
            writer = new CharWriter();
            reader = new CharReader();
        }

        public string Translate(string _text)
        {
            string text = reader.Read(_text);
            return writer.Write(text);
        }
    }
}