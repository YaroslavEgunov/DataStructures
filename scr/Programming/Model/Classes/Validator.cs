using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value,string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Введите положительное значение в {propertyName}");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Введите положительное значение в {propertyName}");
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
    }
}

