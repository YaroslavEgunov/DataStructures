using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = ObjectOrientedPractics.Services.AppColors;
using ToolTip = System.Windows.Forms.ToolTip;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        private ToolTip _toolTip = new ToolTip();

        private List<Item> _items = new List<Item>();

        private Item _currentItem;

        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ClearItemsTextBox()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            DescriptionTextBox.Text = "";
            CostTextBox.BackColor = Color.CorrectColor;
            NameTextBox.BackColor = Color.CorrectColor;
            DescriptionTextBox.BackColor = Color.CorrectColor;
        }

        private void UpdateItemsTextBox(Item item)
        {
            _currentItem = item;
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                if (_items.Count > 0)
                {
                    ItemsListBox.SelectedIndex = 0;
                }
                else
                {
                    ClearItemsTextBox();
                }
                return;
            }
            _currentItem = _items[ItemsListBox.SelectedIndex];
            UpdateItemsTextBox(_currentItem);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0)
            {
                return;
            }
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add(new Item());
            _currentItem = _items.Last();
            ItemsListBox.Items.Add(_currentItem.Name);
            UpdateItemsTextBox(_currentItem);
            ItemsListBox.SelectedIndex = ItemsListBox.Items.Count - 1;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                CostTextBox.BackColor = Color.CorrectColor;
                UpdateItemsTextBox(_currentItem);
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(CostTextBox, exception.Message);
                CostTextBox.BackColor = Color.WrongColor;
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.SelectionStart = NameTextBox.Text.Length;
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.CorrectColor;
                ItemsListBox.Items[ItemsListBox.SelectedIndex] =
                    NameTextBox.Text;
                UpdateItemsTextBox(_currentItem);
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(NameTextBox, exception.Message);
                NameTextBox.BackColor = Color.WrongColor;
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.CorrectColor;
                UpdateItemsTextBox(_currentItem);
            }
            catch (Exception exception)
            {
                _toolTip.SetToolTip(DescriptionTextBox, exception.Message);
                DescriptionTextBox.BackColor = Color.WrongColor;
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            _items.AddRange(ProjectSerializer.LoadItemsToFile());
            for (int i = 0; i < _items.Count; i++)
            {
                ItemsListBox.Items.Add(_items[i].Name);
            }
        }
    }
}
