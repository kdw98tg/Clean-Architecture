namespace DIP.GoodExample
{
    public class Client
    {
        public IRadioButton radioButton = null;
        private string currentOs = "Window";

        public Client()
        {
            if (currentOs == "Window")
            {
                radioButton = new WindowRadioButton();
            }
            else
            {
                radioButton = new MacRadioButton();
            }
        }

        public void Main()
        {
            radioButton.Render();
        }

    }
}