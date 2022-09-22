using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private ToolTip _toolTip = new ToolTip();

        private List<Customer> _customers = new List<Customer>();

        private Customer _currentCustomer;

        public CustomersTab()
        {
            InitializeComponent();
        }

        private void ClearCustomersTextBox()
        {
            IdCustomersTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";
            FullNameTextBox.BackColor = AppColors.CorrectColor;
            AddressTextBox.BackColor = AppColors.CorrectColor;
        }

        private void UpdateCustomersTextBox(Customer customer)
        {
            _currentCustomer = customer;
            IdCustomersTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName.ToString();
            AddressTextBox.Text = _currentCustomer.Address.ToString();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                if (_customers.Count > 0)
                {
                    CustomersListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearCustomersTextBox();
                }
                return;
            }
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            UpdateCustomersTextBox(_currentCustomer);
        }

        private void RemoveCustomersButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0)
            {
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
        }

        private void AddCustomersButton_Click(object sender, EventArgs e)
        {
            _customers.Add(new Customer());
            _currentCustomer = _customers.Last();
            CustomersListBox.Items.Add(_currentCustomer.FullName);
            UpdateCustomersTextBox(_currentCustomer);
            CustomersListBox.SelectedIndex = CustomersListBox.Items.Count - 1;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.SelectionStart = FullNameTextBox.Text.Length;
                _currentCustomer.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = AppColors.CorrectColor;
                CustomersListBox.Items[CustomersListBox.SelectedIndex] =
                    FullNameTextBox.Text;
                UpdateCustomersTextBox(_currentCustomer);
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(FullNameTextBox, exception.Message);
                FullNameTextBox.BackColor = AppColors.WrongColor;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = AppColors.CorrectColor;
                UpdateCustomersTextBox(_currentCustomer);
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(AddressTextBox, exception.Message);
                AddressTextBox.BackColor = AppColors.WrongColor;
            }
        }
    }
}
