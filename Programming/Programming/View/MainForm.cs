using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            foreach (Enums enumsValues in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(enumsValues);
            }
            EnumsListBox.SelectedIndex = 0;

            var values = Enum.GetValues(typeof(Seasons));
            foreach (var value in values)
            {
                ChooseSeasonComboBox.Items.Add(value);
            }
        }
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values;

            switch (itemType)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Genre:
                    values = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.EducationForm:
                    values = Enum.GetValues(typeof(EducationForm));
                    break;
                case Enums.Manufactures:
                    values = Enum.GetValues(typeof(Manufactures));
                    break;
                case Enums.Seasons:
                    values = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Weekday:
                    values = Enum.GetValues(typeof(Weekday));
                    break;
                default:
                    throw new NotImplementedException();
            }

            foreach (var value in values)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            var text = ParseInput.Text;
            Weekday day;

            if (Enum.TryParse(text, out day))
            {
                OutLabel.Text = $"Это день недели ({day} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;

            switch (item)
            {
                case Seasons.Winter:
                    MainForm.ActiveForm.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    MainForm.ActiveForm.BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    MainForm.ActiveForm.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    MainForm.ActiveForm.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IntBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ParseInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
