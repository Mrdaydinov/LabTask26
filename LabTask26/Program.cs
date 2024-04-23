using LabTask26.Task1;
using LabTask26.Task2;

namespace LabTask26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1


            //User engUser = new User(new EnglishLanguage());
            //User ruUser = new User(new RussianLanguage());
            //User frUser = new User(new FrenchLanguage());

            //engUser.Speak();
            //ruUser.Speak();
            //frUser.Speak();


            //Task 2


            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(3, 7);

            IShape cirShape = circle;
            IShape recShape = rectangle;

            Console.WriteLine("Circle area = " + cirShape.CalculateArea());
            Console.WriteLine("Circle perimeter = " + cirShape.CalculatePerimeter());
            Console.WriteLine("Rectangle area = " + recShape.CalculateArea());
            Console.WriteLine("Rectangle perimeter = " + recShape.CalculatePerimeter());
        }
    }
}
