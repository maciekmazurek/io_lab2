
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
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}