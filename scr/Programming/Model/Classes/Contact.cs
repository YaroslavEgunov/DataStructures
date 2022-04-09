using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _phoneNumber;

        private string _surname;

        private string _name;

        public string Email { get; set; }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                _surname = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Name));
                _name = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string name, string number , string email, string surname)
        {
            _name = name;
            _phoneNumber = number;
            Email = email;
            _surname = surname;
        }

        private void AssertStringContainsOnlyLetters(string value, string fieldName)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) != true)
                {
                    throw new ArgumentException($"Необходимы только английские буквы в {fieldName}");
                }
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (value.Length != 11)
                {
                    throw new ArgumentException("Номер телефона должен состоять из 11 цифр");
                }
                if (!long.TryParse(value, out var x))
                {
                    throw new ArgumentException("Номер должен состоять только из цифр");
                }
                _phoneNumber = value;
            }
        }
    }
}   
