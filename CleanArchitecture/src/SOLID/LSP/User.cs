using System.Diagnostics;
using System.Reflection;
namespace LSP
{
    public class User
    {
        public void Main()
        {
            // Rectangle rectangle = new Rectangle();
            // rectangle.SetHeight(5);
            // rectangle.SetWidth(2);
            // Debug.Assert(rectangle.GetArea() == 10);

            Rectangle square = new Square();
            square.SetHeight(5);
            square.SetWidth(2);
            Debug.Assert(square.GetArea() == 10);
        }

    }
}