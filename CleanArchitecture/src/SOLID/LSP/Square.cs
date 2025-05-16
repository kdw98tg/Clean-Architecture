namespace LSP
{
    public class Square : Rectangle
    {
        public override void SetHeight(int _height)
        {
            base.SetHeight(_height);
            base.SetWidth(_height);
        }

        public override void SetWidth(int _width)
        {
            base.SetWidth(_width);
            base.SetHeight(_width);
        }
    }
}