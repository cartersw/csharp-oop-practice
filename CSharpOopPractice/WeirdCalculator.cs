namespace CSharpIntermediate
{
    public class WeirdCalculator
    {
        public static int Add(params int[] numbers)
        {
            string num = string.Join("", numbers);
            return int.Parse(num);
        }
    }
}