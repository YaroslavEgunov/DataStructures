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
using Rectangle = Programming.Model.Classes.Rectangle;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly System.Drawing.Color WrongColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private readonly System.Drawing.Color CorrectColorPanel = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        private readonly System.Drawing.Color WrongColorPanel = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private Rectangle _currentRectangle = new Rectangle();

        private List<Panel> _rectanglesPanel = new List<Panel>();

        private Movie[] _movies;

        private Movie _currentMovie = new Movie();

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

            InitRectangles();
            InitMovies();
        }

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            double max = 0;
            int currentIndex = -1;
            for (int i = 0; i < rectangles.Count; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    currentIndex = i;
                }
            }
            return currentIndex;
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

        private void InitMovies()
        {
            _movies = new Movie[5];
            Random random = new Random();
            string[] MoviesTitle = {"Holk","Iren Man","Captain Latvia","White window", "Gold Man",
                                   "Pink Panther", "Thor son of the Pluto", "Recruit Marvel",
                                    "Peter-man", "Vatman", "Flash energy",
                                    "Wonder NotHuman", "Super-Monkey" };
            string[] MoviesGenre = { "Horror", "Action", "Comedy", "Fantasy",
                                    "Mystery", "Romance", "Thriller", "Drama" };
            for (var i = 0; i < 5; i++)
            {
                var Title = random.Next(MoviesTitle.Length);
                var Genre = random.Next(MoviesGenre.Length);
                _movies[i] = new Movie(MoviesTitle[Title],
                                      random.Next(1900, DateTime.Now.Year),
                                      Math.Round(random.NextDouble() * 10, 1),
                                      random.Next(60, 180),
                                      MoviesGenre[Genre]);
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            MoviesListBox.SelectedIndex = 0;
        }

        private void InitRectangles()
        {
            string[] RectangleColors = { "White", "Black", "Yellow", "Brown",
                                        "Green", "Red", "Blue", "Purple" };
            Random random = new Random();

            for (var i = 0; i < 5; i++)
            {
                var Colors = random.Next(RectangleColors.Length);
                _rectangles.Add (new Rectangle(random.Next(1, 100),
                                                             random.Next(1, 100),
                                                             RectangleColors[Colors],
                                                             random.Next(1, 100),
                                                             random.Next(1, 100)));
                RectanglesListBoxInClasses.Items.Add($"Rectangle {i + 1}");
            }

            RectanglesListBoxInClasses.SelectedIndex = 0;
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
            RectanglesListBoxInClasses.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBoxInClasses.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            CoordinateXTextBox.Text = _currentRectangle.Center.X.ToString();
            CoordinateYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IDTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = Convert.ToDouble(LengthTextBox.Text);
                LengthTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = WrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: {CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
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
                WidthTextBox.BackColor = WrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: {CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
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
                DurationInMinutesTextBox.BackColor = WrongColor;
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
                YearTextBox.BackColor = WrongColor;
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
                RatingTextBox.BackColor = WrongColor;
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

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }




        private void ClearRectangleInfo()
        {
            _currentRectangle = null;
            IdPanelTextBox.Text = "";
            XPanelTextBox.Text = "";
            YPanelTextBox.Text = "";
            WidthPanelTextBox.Text = "";
            HeightPanelTextBox.Text = "";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            _currentRectangle = rectangle;
            IdPanelTextBox.Text = _currentRectangle.Id.ToString();
            XPanelTextBox.Text = _currentRectangle.Center.X.ToString();
            YPanelTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthPanelTextBox.Text = _currentRectangle.Width.ToString();
            HeightPanelTextBox.Text = _currentRectangle.Length.ToString();
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglesPanel.Count; i++)
            {
                _rectanglesPanel[i].BackColor = CorrectColorPanel;
            }
            for (int i = 0; i < _rectangles.Count; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglesPanel[i].BackColor = WrongColorPanel;
                        _rectanglesPanel[j].BackColor = WrongColorPanel;
                    }
                }
            }
        }

        private void AddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPictureBox.Image = Image.FromFile(@"C:\Users\anton\source\repos\Programming\resources\rectangle_add_24x24.png");
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Image.FromFile(@"C:\Users\anton\source\repos\Programming\resources\rectangle_add_24x24_uncolor.png");
        }

        private void DeletePictureBox_MouseEnter(object sender, EventArgs e)
        {
            DeletePictureBox.Image = Image.FromFile(@"C:\Users\anton\source\repos\Programming\resources\rectangle_remove_24x24.png");
        }

        private void DeletePictureBox_MouseLeave(object sender, EventArgs e)
        {
            DeletePictureBox.Image = Image.FromFile(@"C:\Users\anton\source\repos\Programming\resources\rectangle_remove_24x24_uncolor.png");
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            _rectangles.Add(new Rectangle(
                random.Next(10, 100),
                random.Next(10, 100),
                "White",
                random.Next(10, 100),
                random.Next(10, 100)));

            _currentRectangle = _rectangles[_rectangles.Count- 6];
            RectanglesPanelListBox.Items.Add(
                $"{_currentRectangle.Id}:" +
                $"(X = {_currentRectangle.Center.X};" +
                $"Y = {_currentRectangle.Center.Y};" +
                $"W = {_currentRectangle.Width};" +
                $"H = {_currentRectangle.Length})");
        }

        private void DeletePictureBox_Click(object sender, EventArgs e)
        {
            if (_currentRectangle == null || RectanglesPanelListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                _rectangles.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                RectanglesPanelListBox.Items.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                if (RectanglesPanelListBox.Items.Count > 0)
                {
                    RectanglesPanelListBox.SelectedIndex = 0;
                }
            }
        }

        
        private void RectanglesPanelListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesPanelListBox.SelectedIndex == -1)
            {
                ClearRectangleInfo();
            }
            else
            {
                _currentRectangle = _rectangles[RectanglesPanelListBox.SelectedIndex];
                UpdateRectangleInfo(_currentRectangle);
            }
        }

        private void UpdatePanelListBox()
        {
            RectanglesPanelListBox.Items[RectanglesPanelListBox.SelectedIndex] =
                    $"{_currentRectangle.Id}:" +
                    $"(X = {_currentRectangle.Center.X};" +
                    $"Y = {_currentRectangle.Center.Y};" +
                    $"W = {_currentRectangle.Width};" +
                    $"H = {_currentRectangle.Length})";
        }

        private void HeightPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                _currentRectangle.Length = Int32.Parse(HeightPanelTextBox.Text);
                Validator.AssertOnPositiveValue(_currentRectangle.Length, nameof(HeightPanelTextBox));
                HeightPanelTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(HeightPanelTextBox, "");
                UpdatePanelListBox();
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch (Exception exception)
            {
                HeightPanelTextBox.BackColor = WrongColor;
                toolTip.SetToolTip(HeightPanelTextBox, exception.Message);
                return;
            }
        }

        private void XPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                _currentRectangle.Center.X = Int32.Parse(XPanelTextBox.Text);
                XPanelTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(XPanelTextBox, "");
                UpdatePanelListBox();
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch (Exception exception)
            {
                XPanelTextBox.BackColor = WrongColor;
                toolTip.SetToolTip(XPanelTextBox, exception.Message);
                return;
            }
        }

        private void YPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                _currentRectangle.Center.Y = Int32.Parse(YPanelTextBox.Text);
                YPanelTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(YPanelTextBox, "");
                UpdatePanelListBox();
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch (Exception exception)
            {
                YPanelTextBox.BackColor = WrongColor;
                toolTip.SetToolTip(YPanelTextBox, exception.Message);
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                _currentRectangle.Width = Int32.Parse(WidthPanelTextBox.Text);
                Validator.AssertOnPositiveValue(_currentRectangle.Width, nameof(WidthPanelTextBox));
                WidthPanelTextBox.BackColor = CorrectColor;
                toolTip.SetToolTip(WidthPanelTextBox, "");
                UpdatePanelListBox();
                UpdateRectangleInfo(_currentRectangle);
                FindCollisions();
            }
            catch (Exception exception)
            {
                WidthPanelTextBox.BackColor = WrongColor;
                toolTip.SetToolTip(WidthPanelTextBox, exception.Message);
                return;
            }
        }

    }
    
}
