using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        public string Name { get; set; }
        private string _phoneNumber;
        public string Email { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string email, string number)
        {
            Name = name;
            Email = email;
            _phoneNumber = number;
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
                else if (long.TryParse(value, out var x) == false)
                {
                    throw new ArgumentException("Номер должен состоять только из цифр");
                }
                _phoneNumber = value;
            }
        }    
        

    }
}   
