namespace IztekTestCase.Models
{
    public class Input
    {
        public Guid id { get; set; }
        public int input { get; set; }
        public bool isPrime { get; set; }

        public Input(int input)
        {
            this.input = input;

            if (CheckPrime(input)) { this.isPrime = true; }
            else { this.isPrime = false; }
        }

        public bool CheckPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i <= number / 2; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
