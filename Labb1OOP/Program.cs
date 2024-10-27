namespace Labb1OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);//nytt objekt av klassen Circle
            Circle circle2 = new Circle(6);

            float area1 = circle1.GetArea();// räkna ut arean för cirklarna
            float area2 = circle2.GetArea();

            Console.WriteLine($"Arean för cirkeln med radien 5 blir: {area1}");
            Console.WriteLine($"Arean för cirkeln med radien 6 blir: {area2}");
        }
    }
}
