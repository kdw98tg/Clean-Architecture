namespace EntityRecycle.Correct
{
    public class Client
    {
        private readonly UserEntity user;

        public Client()
        {
            user = new UserEntity();
        }

        public void Main()
        {
            if (user.IsAdult())
            {
                //SomeLogic
            }
        }

        public void UpdateAdult()
        {
            if (user.IsAdult())
            {
                //Some Login
            }
        }
    }
}