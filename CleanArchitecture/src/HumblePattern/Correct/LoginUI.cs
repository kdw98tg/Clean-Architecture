namespace CleanArchitecture.src.HumblePattern.Correct
{
    public class LoginUI
    {
        private readonly TextView textView = null;
        private readonly LoginService loginService = null;

        public LoginUI()
        {
            textView = new TextView();
            loginService = new LoginService();
        }

        private void OnLoginButtonClicked()
        {
            MessageView messageView = new MessageView();
            if (loginService.OnLogin("123"))
            {
                messageView.Show("로그인 성공!");
            }
            else
            {
                messageView.Show("로그인 실패!");
            }
        }
    }
}
