﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
           for(int i =0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length ==0)
            {
                return false;
            }
            for(int i =1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                
            }
            return true;
            
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int sum = 0;
            for(int i= 1; i < numbers.Length; i++)
            {
                if (numbers[i-1] %2 ==0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if(words == null || words.Length ==0)
            {
                return "";
            }
            string sentenceBuilder="";
            foreach(string word in words)
            {
                if(word.Trim().Length > 0)
                {
                    sentenceBuilder += word.Trim() + " ";
                }
            }
            if(sentenceBuilder.Length == 0)
            {
                return "";
            }
            sentenceBuilder = sentenceBuilder.Trim();
            sentenceBuilder += ".";
            return sentenceBuilder;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count== 0)
            {
                return new double[0];
            }
            List<double> every4th = new List<double>();
            for(var i = 3; i < elements.Count; i+=4)
            {
                every4th.Add(elements[i]);
            }
            return every4th.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0 ; i < nums.Length; i++)
            {
                for(int j = i +1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }
    }
}
