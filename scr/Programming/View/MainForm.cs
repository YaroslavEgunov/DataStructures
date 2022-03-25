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

        private Model.Classes.Film[] _films;

        private Model.Classes.Film _currentFilm = new Model.Classes.Film();



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

            string[] FilmsTitle = {"Holk", "Iren Man", "Captain Latviya", "White window", "Gold Man",
                                   "Pink Panther", "Tor son of the Pluto", "Recruit Marvel", "Peter-man", 
                                   "Vatman", "Flash energy", "Wonder NotHuman", "Super-Monkey" };

            string[] RectangleColors = { "White", "Black", "Yellow", "Brown", "Green", "Red", "Blue", "Purple" };

            string[] FilmsGenre = { "Horror", "Action", "Comedy", "Fantasy", "Mystery", "Romance", "Thriller", "Drama" };


            _rectangles = new Model.Classes.Rectangle[5];
            _films = new Film[5];
            Random random = new Random();
            for (var i = 0; i < 5; i++)
            {
                var Title = random.Next(FilmsTitle.Length);
                var Colors = random.Next(RectangleColors.Length);
                var Genre = random.Next(FilmsGenre.Length);

                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 100), random.Next(1, 100), RectangleColors[Colors]);
                RectangleslistBox.Items.Add($"Rectangle {i + 1}");
                _films[i] = new Film(random.Next(0, 180), random.Next(1900, 2022), random.Next(0,10),FilmsTitle[Title], FilmsGenre[Genre]);
                FilmslistBox.Items.Add($"Film {i + 1}");
            }
            RectangleslistBox.SelectedIndex = 0;
            FilmslistBox.SelectedIndex = 0;
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





        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            RectangleslistBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
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
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            int Index = 0;
            double maxValues = 0;
            for (var i = 0; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxValues)
                {
                    maxValues = rectangles[i].Width;
                    Index = i;
                }
            }
            return Index;
        }





        private void FilmslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmslistBox.SelectedIndex];
            DurationTextBox.Text = _currentFilm.Duration.ToString();
            YearTextBox.Text = _currentFilm.Year.ToString();
            RatingTextBox.Text = _currentFilm.Rating.ToString();
            TitleTextBox.Text = _currentFilm.Title;
            GenreTextBox.Text = _currentFilm.Genre;


        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Duration = Convert.ToInt32(DurationTextBox.Text);
                DurationTextBox.BackColor = System.Drawing.Color.White;
                toolTip.SetToolTip(DurationTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(DurationTextBox, exception.Message);
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Year = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = System.Drawing.Color.White;
                toolTip.SetToolTip(YearTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(YearTextBox, exception.Message);
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = Convert.ToInt32(RatingTextBox.Text);
                RatingTextBox.BackColor = System.Drawing.Color.White;
                toolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = Convert.ToString(GenreTextBox.Text);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Title = Convert.ToString(TitleTextBox.Text);
        }

        private int FindFilmWithMaxRating(Film[] films)
        {
            int Index = 0;
            double maxValues = 0;
            for (var i = 0; i < films.Length; i++)
            {
                if (films[i].Rating > maxValues)
                {
                    maxValues = films[i].Rating;
                    Index = i;
                }
            }
            return Index;
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            FilmslistBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }
    }
}
