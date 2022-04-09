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
                throw new ArgumentException($"Введите положительное значение в {fieldName}");
            }
        }

        public static void AssertOnPositiveValue(double value, string fieldName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Введите положительное значение в {fieldName}");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string fieldName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException(
                    $" Введите значение в {fieldName} в корректном диапазоне");
            }
        }

        public static void AssertValueInRange(double value, int min, int max, string fieldName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException(
                    $"Введите значение в {fieldName} в корректном диапазоне");
            }
        }

        public static void AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) != true)
                {
                    throw new ArgumentException($"Необходимы только английские буквы в {fieldName}");
                }
            }
        }

        public static void AssertInRadius(double value, double outRadius)
        {
            if (value > outRadius)
            {
                throw new ArgumentException("Внутренний радиус не может быть больше внешнего");
            }
        }

        public static void AssertOutRadius(double value, double inRadius)
        {
            if (value < inRadius)
            {
                throw new ArgumentException("Внешний радиус не может быть меньше внуреннего");
            }
        }
    }
}

