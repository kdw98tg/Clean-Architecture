namespace DIP.BadExample
{
    public class Client
    {
        private MacRadioButton macRadioButton = null;
        private WindowRadioButton windowRadioButton = null;

        private string currentOs = null;

        public Client()
        {
            macRadioButton = new MacRadioButton();
            windowRadioButton = new WindowRadioButton();

            currentOs = "Mac";
        }

        public void Main()
        {
            if (currentOs == "Mac")
            {
                macRadioButton.Render();
            }
            else
            {
                windowRadioButton.Render();
            }
        }
    }
}