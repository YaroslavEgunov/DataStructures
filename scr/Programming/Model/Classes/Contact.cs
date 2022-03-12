using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string Name { get; set; }
        private string PhoneNumber;
        private string Email { get; set; }

        void SetPhone_number(Contact сontact, string phoneNumber)
        {
            if (phoneNumber.Length != 11)
            {
                throw new ArgumentException("Номер телефона должен состоять из 11 цифр");
            }
            else if (int.TryParse(phoneNumber, out int num) == false)
            {
                throw new ArgumentException("Номер должен состоять только из цифр");
            }
            сontact.PhoneNumber = phoneNumber;

        }
    }
}   
