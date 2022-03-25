using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles;

        private Model.Classes.Rectangle _currentRectangle = new Model.Classes.Rectangle();

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

            _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (var i = 0; i < 5; i++)
            {
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 100), random.Next(1, 100), "White");
                RectangleslistBox.Items.Add($"Rectangle {i + 1}");
            }
            RectangleslistBox.SelectedIndex = 0;
        }

        

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            var item = EnumsListBox.SelectedItem;
            var itemType = (Enums)item;
            Array values  = null;

            switch (itemType)
            {
                case Enums.Color:
                    values = Enum.GetValues(typeof(Model.Enums.Color));
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
                OutLabel.Text = $"Это день недели ({ParseInput.Text} = {(int)day})";
            }
            else
            {
                OutLabel.Text = "Нет такого дня недели!";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            var item = ChooseSeasonComboBox.SelectedItem;

            if (ChooseSeasonComboBox.SelectedItem == null)
            {
                return;
            }

            switch (item)
            {
                case Seasons.Winter:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Бррр! Холодно!");
                    break;
                case Seasons.Summer:
                    BackColor = ColorTranslator.FromHtml("#ffffff");
                    MessageBox.Show(@"Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                case Seasons.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                default:
                    throw new NotImplementedException();
            }
        }





        private void FindButton_Click(object sender, EventArgs e)
        {

        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectangleslistBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;

        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToDouble(LenghtTextBox.Text);
                LenghtTextBox.BackColor = System.Drawing.Color.White;
                toolTip.SetToolTip(LenghtTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(LenghtTextBox, exception.Message);
                LenghtTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = System.Drawing.Color.White;
                toolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }


    }
}
