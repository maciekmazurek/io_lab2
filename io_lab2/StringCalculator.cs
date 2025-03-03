
namespace io_lab2
{
    public class StringCalculator
    {
        public int Calculate(string input)
        {
            if (input.Length == 0)
            {
                return 0;
            }
            else if (int.TryParse(input, out var result))
            {
                return result;
            }

            var nums = input.Split(',');

            if (nums.Count() == 2 && int.TryParse(nums[0], out var firstNum) && int.TryParse(nums[1], out var secondNum))
            {
                return firstNum + secondNum;
            }

            throw new NotImplementedException();
        }
    }
}