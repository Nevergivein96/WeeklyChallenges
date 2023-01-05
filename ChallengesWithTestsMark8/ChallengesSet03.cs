using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if(vals == null) return false;
            foreach(var v in vals)
            {
                if(v == false)
                {
                    return true;
                }
               
            }
            return false;
            throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
            throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit);


            throw new NotImplementedException();
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();

            throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if(divisor== 0) return 0;
            return dividend / divisor;
            throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
            throw new NotImplementedException();
        }

        public int[] GetOddsBelow100()
        {
            int[] myArray = new int[50];
            int index = 0;
            for(int i = 0; i < 100; i++)
            {
                if(i % 2 != 0)
                {
                    myArray[index++] = i;
                }
            }
            return myArray;
            throw new NotImplementedException();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
