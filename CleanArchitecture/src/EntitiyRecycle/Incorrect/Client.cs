namespace EntityRecycle.Incorrect
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
            if (user.Age > 19)
            {
                //SomeLogic
            }
        }

        public void UpdateAdult()
        {
            if (user.Age > 19)
            {
                //Some Login
            }
        }
    }
}