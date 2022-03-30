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

        public string Name { get; set; }

        public string Email { get; set; }

        public Contact()
        {
        }

        public Contact(string name, string number , string email)
        {
            Name = name;
            _phoneNumber = number;
            Email = email;
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
