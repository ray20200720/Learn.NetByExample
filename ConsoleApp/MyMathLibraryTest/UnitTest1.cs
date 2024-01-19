using MyMathLibrary;

namespace MyMathLibraryTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestSquare()
    {
        // int input = 5;
        // int expectedOutput = 25;

        // int actualOutput = new MyMath().square(input);

        // Assert.AreEqual(expectedOutput, actualOutput);

        int[] inputArray = { 1, 2, 3, 4, 5 };
        int[] expectedOutputArray = { 1, 4, 9, 16, 25 };

        var index = 0;
        var myMath = new MyMath();
        foreach(var input in inputArray)
        {
            var actualOupt = myMath.Square(input);
            //Console.WriteLine("input:{0}, output:{1}", input, actualOupt);
            Assert.AreEqual(expectedOutputArray[index], actualOupt);    
            index++;
        }
    }

    [TestMethod]
    public void TestCube()
    {
        int input = 5;
        int expectedOutput = 125;

        int actualOutput = new MyMath().Cube(input);

        Assert.AreEqual(expectedOutput, actualOutput);
    }
}