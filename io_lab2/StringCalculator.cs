
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

            var numsSplitted1 = input.Split(',');
            if (numsSplitted1.Count() == 2 && int.TryParse(numsSplitted1[0], out var firstNum) && int.TryParse(numsSplitted1[1], out var secondNum))
            {
                return firstNum + secondNum;
            }

            var numsSplitted2 = input.Split("\n");
            if (numsSplitted2.Count() == 2 && int.TryParse(numsSplitted2[0], out var thirdNum) && int.TryParse(numsSplitted2[1], out var fourthNum))
            {
                return thirdNum + fourthNum;
            }


            throw new NotImplementedException();
        }
    }
}