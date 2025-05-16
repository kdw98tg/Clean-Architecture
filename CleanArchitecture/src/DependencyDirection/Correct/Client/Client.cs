namespace DependencyDirection.Correct
{
    //저수준의 모듈 (입출력 관련) 에서 고수준 모듈로 의존성을 역전하였음
    //이렇게하면 고수준의 모듈은 저수준의 모듈에게 의존성이 없어짐
    //이게 옳게된 구조라고 함
    //지금 나눈 Client 와 LowLevelModeul이 경계선이 되는것임
    public class Client
    {
        private readonly Translate translate;

        public Client()
        {
            translate = new Translate();
        }

        public void Main()
        {
            translate.Translate("Some Text");
        }
    }
}