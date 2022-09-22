using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View
{
    public partial class MaiForm : Form
    {
        public MaiForm()
        {
            InitializeComponent();
        }

        private void MaiForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectSerializer.SaveItemsToFile(_items);
            ProjectSerializer.SaveCustomersToFile(_customers);
        }
    }
}
