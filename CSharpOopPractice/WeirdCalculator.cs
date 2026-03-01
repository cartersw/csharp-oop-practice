namespace CSharpIntermediate
{
    public class WeirdCalculator
    {
        public static int Add(params int[] numbers)
        {
            if(numbers.Length > 0){
                string num = string.Join("", numbers);
                return int.Parse(num);
            }
            return 0;
        }
    }
}