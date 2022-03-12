using System;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string Name { get; set; }
        private int Phone_number;
        private string Email { get; set; }

        void SetPhone_number(Contact сontact, int phone_number)
        {
            if (phone_number != 11)
            {
                throw new ArgumentException("Номер телефона должен состоять из 11 цифр");
            }
            сontact.Phone_number = phone_number;
        }
    }
}   
