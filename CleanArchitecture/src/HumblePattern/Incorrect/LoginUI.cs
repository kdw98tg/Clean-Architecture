namespace CleanArchitecture.src.HumblePattern.Incorrect
{
    public class LoginUI
    {
        private readonly TextView textView;

        public LoginUI()
        {
            textView = new TextView();
        }

        private void OnLoginButtonClicked()
        {
            if (textView.Text == "123")
            {
                RequestLogin();
            }
            else
            {
                MessageView messageView = new MessageView();
                messageView.Show("로그인 실패!");
            }
        }

        private void RequestLogin()
        {
            //Login Logic
            bool onSuccess = false;
            if (onSuccess)
            {
                MessageView messageView = new MessageView();
                messageView.Show("로그인 성공!");
            }
        }
    }
}
