using System.Reflection.Metadata.Ecma335;

public class Program
{
    public static void Main()
    {
        const string MsgInput = "Input a number to check if it's between the range [10, 50]: ";
        const string MsgError = "Invalid input.";
        const string MsgRangeTrue = "Number {0} is between the range [10, 50].";
        const string MsgRangeFalse = "Number {0} is NOT between the range [10, 50].";

        int input;
        bool isInput, isRange;

        do
        {
            Console.WriteLine(MsgInput);
            isInput = Int32.TryParse(Console.ReadLine(), out input);
            if (!isInput)
            {
                Console.WriteLine(MsgError);
            }
        } while (!isInput);
        isRange = NumberInRange(input);
        if (isRange)
        {
            Console.WriteLine(MsgRangeTrue, input);
        }
        else Console.WriteLine(MsgRangeFalse, input);
    }


    public static bool NumberInRange(int value)
    {
        int lowerEnd = 10, higherEnd = 50;
        bool isRange;


        if (value >= lowerEnd && value <= higherEnd)
        {
            isRange = true;
        }
        else isRange = false;

        return isRange;
    }
}
