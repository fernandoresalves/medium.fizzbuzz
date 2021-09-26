using System.Collections.Generic;

namespace FizzBuzz.Logic
{
    public static class FizzBuzz
    {
        public static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        public static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public static bool IsFizzBuzz(int number)
        {
            return IsFizz(number) && IsBuzz(number);
        }

        public static string Get(int number)
        {
            if (IsFizz(number))
                return "Fizz";
            if (IsBuzz(number))
                return "Buzz";
            if (IsFizzBuzz(number))
                return "FizzBuzz";
            else
                return number.ToString();
        }

        public static IList<string> Get(IList<int> numbers)
        {
            var result = new List<string>();

            foreach(var number in numbers)
            {
                result.Add(Get(number));
            }

            //yield return
            return result;
        }
    }
}
