namespace DependencyDirection.Incorrect
{
    //의존성의 흐름이 고수준 -> 저수준 모듈로 향한다
    //Client -> Translate |-> CharReader 
    //                    |-> CharWriter
    //좋은 방향은 저수준 모듈에서 고주순 모듈로 향하게 하는것이다.
    //인터페이스로 묶어서 사용하도록 한다.
    public class Client
    {
        private readonly Translate translate;

        public Client()
        {
            translate = new Translate();
        }

        public void Main()
        {
            translate.TranslateText("Some Text");
        }
    }
}