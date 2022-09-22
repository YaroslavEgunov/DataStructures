using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    class Customer
    {
        /// <summary>
        /// Уникальный индетификатор.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя. Должно быть меньше 200 символов.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес доставки. Должен быть меньше 500 символов.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя товара. Должно быть не больше 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                Validator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес доставки товара. Должен быть не больше 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="Id">Уникальный индетификатор.</param>
        /// <param name="FullName">Полное имя покупателя. Должно быть меньше 200 символов.</param>
        /// <param name="Address">Адрес доставки. Должен быть меньше 500 символов.</param>
        public Customer(int Id, string FullName, string Address)
        {
            _id = IdGenerator.GetNextId();
            FullName = _fullName;
            Address = _address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _id = IdGenerator.GetNextId();
            FullName = "Empty";
            Address = "Empty";
        }
    }
}
