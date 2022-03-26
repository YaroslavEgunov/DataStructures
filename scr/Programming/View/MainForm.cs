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

        private Model.Classes.Movie[] _movies;

        private Model.Classes.Movie _currentMovie = new Movie();

        private readonly System.Drawing.Color ExceptionColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

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

            string[] MoviesTitle = {"Holk","Iren Man","Captain Latvia","White window", "Gold Man",
                                   "Pink Panther", "Thor son of the Pluto", "Recruit Marvel", 
                                    "Peter-man", "Vatman", "Flash energy", 
                                    "Wonder NotHuman", "Super-Monkey" };
            string[] RectangleColors = { "White", "Black", "Yellow", "Brown", 
                                        "Green", "Red", "Blue", "Purple" };
            string[] MoviesGenre = { "Horror", "Action", "Comedy", "Fantasy", 
                                    "Mystery", "Romance", "Thriller", "Drama" };

            _rectangles = new Model.Classes.Rectangle[5];
            _movies = new Movie[5];
            Random random = new Random();

            for (var i = 0; i < 5; i++)
            {
                var Colors = random.Next(RectangleColors.Length);
                _rectangles[i] = new Model.Classes.Rectangle(random.Next(1, 100),
                                                             random.Next(1, 100),
                                                             RectangleColors[Colors]);
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            for (var i = 0; i < 5; i++)
            {
                var Title = random.Next(MoviesTitle.Length);
                var Genre = random.Next(MoviesGenre.Length);
                _movies[i] = new Movie(MoviesTitle[Title],
                                      random.Next(1900, DateTime.Now.Year),
                                      Math.Round(random.NextDouble()*10, 1),
                                      random.Next(60, 180), 
                                      MoviesGenre[Genre]);
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }

            RectanglesListBox.SelectedIndex = 0;
            MoviesListBox.SelectedIndex = 0;
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
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LenghtTextBox.Text = _currentRectangle.Lenght.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Lenght = Convert.ToDouble(LenghtTextBox.Text);
                LenghtTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(LenghtTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(LenghtTextBox, exception.Message);
                LenghtTextBox.BackColor = ExceptionColor;
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = ExceptionColor;
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

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            DurationInMinutesTextBox.Text = _currentMovie.DurationInMinutes.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            TitleTextBox.Text = _currentMovie.Title;
            GenreTextBox.Text = _currentMovie.Genre;
        }

        private void DurationInMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.DurationInMinutes = Convert.ToInt32(DurationInMinutesTextBox.Text);
                DurationInMinutesTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(DurationInMinutesTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(DurationInMinutesTextBox, exception.Message);
                DurationInMinutesTextBox.BackColor = ExceptionColor;
            }

        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(YearTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(YearTextBox, exception.Message);
                YearTextBox.BackColor = ExceptionColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = ExceptionColor;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = Convert.ToString(GenreTextBox.Text);
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Title = Convert.ToString(TitleTextBox.Text);
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int index = 0;
            double maxValues = 0;
            for (var i = 0; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxValues)
                {
                    maxValues = movies[i].Rating;
                    index = i;
                }
            }
            return index;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
