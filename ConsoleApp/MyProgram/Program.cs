using MyMathLibrary;

class Program
{
    static void Main(string[] args)
    {
        MyMath math = new MyMath();
        
        Console.WriteLine("math.Square({0})={1}", 4, math.Square(4));
        Console.WriteLine("math.Cube({0})={1}", 4, math.Cube(4));
    }
}
