namespace Labb1OOP
{
    public class Circle
    {
        float _pi = 3.141f;
        int Radius;
        public Circle(int radius)
        {
            Radius = radius;//initierar radien 
        }

        public float GetArea()
        {
            return Radius * Radius * _pi;//metod för att beräkna arean
        }
    }
}
