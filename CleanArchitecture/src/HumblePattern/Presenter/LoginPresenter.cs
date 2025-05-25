namespace CleanArchitecture.src.HumblePattern.Presenter
{
    public class LoginPresenter
    {
        private readonly LoginUI loginView;
        private readonly LoginService loginService;

        public LoginPresenter(LoginUI _loginView)
        {
            this.loginView = _loginView;
            this.loginService = new LoginService();
        }

        public void OnLogin(string _password)
        {
            if (loginService.OnLogin(_password))
            {
                loginView.ShowMessage("로그인 성공!");
            }
            else
            {
                loginView.ShowMessage("로그인 실패!");
            }
        }
    }
}
