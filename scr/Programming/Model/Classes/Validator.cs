using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value,string fieldName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Enter a positive value in {fieldName}");
            }
        }

        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Enter a positive value in {fieldName}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string fieldName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException(
                    $"Enter a value  in {fieldName} within the valid range");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException(
                    $"Enter a value  in {fieldName} within the valid range");
            }
        }

        public static void AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) != true)
                {
                    throw new ArgumentException($"Only English letters are required in " +
                                                $"{fieldName}");
                }
            }
        }
    }
}

