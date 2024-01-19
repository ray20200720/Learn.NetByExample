using MyMathLibrary;

class Program
{
    static void Main(string[] args)
    {
        MyMath math = new MyMath();
        Console.WriteLine("math.square({0})={1}", 4, math.square(4));
    }
}
