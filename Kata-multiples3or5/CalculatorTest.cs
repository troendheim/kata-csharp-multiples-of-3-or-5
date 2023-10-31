namespace Kata_multiples3or5;

public class UnitTest1
{
    [Fact]
    public void TestFindingNumbers()
    {
        var calculator = new Calculator();
        var multiplesOfFiveOrThree = calculator.getNaturalNumbersBelow(100);

        Assert.All<int>(multiplesOfFiveOrThree, (value, index) =>
        {
            Assert.True(value % 3 == 0 || value % 5 == 0);
        });
        
        Assert.Equal(multiplesOfFiveOrThree, multiplesOfFiveOrThree.Distinct());
    }

    [Fact]
    public void TestSumByList()
    {
        var calculator = new Calculator();
        Assert.Equal(3+6+9+12, calculator.Sum(new List<int> { 3, 6, 9, 12 }));
        Assert.Equal(5+10+15+20+30, calculator.Sum(new List<int> { 5, 10, 15, 20, 30 }));
    }
    
    [Fact]
    public void TestSumBelow()
    {
        var calculator = new Calculator();

        var numbers = calculator.getNaturalNumbersBelow(300);
        var sum = calculator.Sum(numbers);
        
        Assert.Equal(sum, calculator.Sum(300));
    }
}