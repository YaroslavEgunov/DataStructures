using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name { get; set; }
        private string _phoneNumber;
        private string _email { get; set; }

        public Contact()
        {

        }

        public Contact(string name, string email, string number)
        {
            _name = name;
            _email = email;
            _phoneNumber = number;
        }

        void SetPhone_number(Contact сontact, string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                throw new ArgumentException("Номер телефона должен состоять из 11 цифр");
            }
            else if (int.TryParse(phoneNumber, out var x) == false)
            {
                throw new ArgumentException("Номер должен состоять только из цифр");
            }
            сontact._phoneNumber = phoneNumber;
        }

    }
}   
