namespace SimpleCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; } = 0;
        public int SecondNumber { get; set; } = 0;
        public int Add()
        {
            return FirstNumber + SecondNumber;
        }
    }
}
