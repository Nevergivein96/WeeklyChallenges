﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            { return true; }
            return false;   

            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {

            if (number % 2 == 0) return true;
            return false;
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0) return false;  return true;
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() == 0) return 0;

            return numbers.Min() + numbers.Max();
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if(str1.Length<str2.Length)
            {
                return str1.Length;     
            }
            return str2.Length;
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null)
                return 0;
            return numbers.Sum();

            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if(numbers == null)
                return 0;
            return numbers.Where(x => x % 2 == 0).Sum();

           for(int i = 0; i < numbers.Length; i++)
            {

            }
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Sum() % 2 != 0;



            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
                return 0;
            else
            {
                return number / 2;
            }

            throw new NotImplementedException();
        }
    }
}
