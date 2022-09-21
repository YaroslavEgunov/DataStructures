using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки введённых значений.
    /// </summary>
    class Validator
    {
        /// <summary>
        /// Проверят, меньше ли строка введённого значения. 
        /// </summary>
        /// <param name="string">Строка, которую проверяют.</param>
        /// <param name="value">Значение, не больше которого должна быть строка.</param>
        /// <param name="fieldName">Имя свойства или объекта, 
        /// которое подлежит проверке.</param>
        public static void AssertOnCharactersRange
            (string @string , int value, string fieldName)
        {
            if (@string.Length > value)
            {
                throw new ArgumentException
                    ($"{fieldName} can't be more than {value} characters");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string fieldName)
        {
            if (!(value >= min) || !(value <= max))
            {
                throw new ArgumentException(
                    $"Value  in {fieldName} must be greater than {min} and less than {max}");
            }
        }

    }
}
