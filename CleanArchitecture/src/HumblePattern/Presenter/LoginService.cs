namespace CleanArchitecture.src.HumblePattern.Presenter
{
    public class LoginService
    {
        public bool OnLogin(string _password)
        {
            if (_password == "123")
                return true;
            else
                return false;
        }
    }
}
