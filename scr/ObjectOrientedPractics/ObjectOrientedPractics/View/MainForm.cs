using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MaiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectSerializer.SaveItemsData(itemsTab1.ItemsData);
            ProjectSerializer.SaveCustomersData(customersTab1.CustomerData);
        }
    }
}
