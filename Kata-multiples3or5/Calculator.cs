namespace Kata_multiples3or5;

public class Calculator
{
    public int Sum(int below) => Sum(getNaturalNumbersBelow(below));

    public int Sum(List<int> numbers) => numbers.Sum();

    public List<int> getNaturalNumbersBelow(int below)
    {
        var listOfNumbers = new List<int>();
        for (int i = 1; i < below; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                listOfNumbers.Add(i);
            }
        }

        return listOfNumbers;
    }
}