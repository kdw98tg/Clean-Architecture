namespace CleanArchitecture.src.HumblePattern.Presenter
{
    public class LoginUI
    {
        private readonly LoginPresenter presenter = null;

        public LoginUI()
        {
            presenter = new LoginPresenter(this);
        }

        public void OnLoginButtonClicked()
        {
            presenter.OnLogin("123");
        }

        public void ShowMessage(string _message)
        {
            MessageView view = new MessageView();
            view.Show(_message);
        }
    }
}
