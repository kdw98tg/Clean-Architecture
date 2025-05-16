namespace LSP
{
    public class Rectangle
    {
        protected int height = 0;
        protected int width = 0;
        public virtual void SetHeight(int _height)
        {
            //높이를 설정하는 메서드
            this.height = _height;
        }

        public virtual void SetWidth(int _width)
        {
            //너비를 설정하는 메서드
            this.width = _width;
        }

        public virtual int GetArea()
        {
            return height * width;
        }
    }
}