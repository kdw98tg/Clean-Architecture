namespace EntityRecycle.Correct
{
    public class UserEntity
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        public bool IsAdult()
        {
            return Age >= 19;
        }
    }
}