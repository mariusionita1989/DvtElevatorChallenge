namespace DvtElevatorChallenge
{
    public static class RandomGenerator
    {
        private static readonly Random random = new Random();
        public static List<int>? GenerateRandInts(int length, int maxValue)
        {
            List<int>? randomNumbers = null;
            if (length > 0 && maxValue > 0) 
            {
                randomNumbers = new List<int>();
                for (int i = 0; i < length; i++)
                {
                    int randomNumber = random.Next(maxValue + 1); // Generates a random integer between 0 and maxValue (inclusive)
                    randomNumbers.Add(randomNumber);
                }
            }
               
            return randomNumbers;
        }
    }
}
