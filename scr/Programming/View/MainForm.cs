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
        private readonly System.Drawing.Color _wrongColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctColor = System.Drawing.Color.White;

        private readonly System.Drawing.Color _correctColorPanel = System.Drawing.Color.FromArgb
                                                                            (127, 127, 255, 127);

        private readonly System.Drawing.Color _wrongColorPanel = System.Drawing.Color.FromArgb
                                                                            (127, 255, 127, 127);

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
                                                             random.Next(1, 400),
                                                             random.Next(1, 400)));
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
                LengthTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = _wrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: " +
                $"{CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = _wrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: " +
                $"{CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
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
                DurationInMinutesTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(DurationInMinutesTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(DurationInMinutesTextBox, exception.Message);
                DurationInMinutesTextBox.BackColor = _wrongColor;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
                YearTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(YearTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(YearTextBox, exception.Message);
                YearTextBox.BackColor = _wrongColor;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                RatingTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(RatingTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(RatingTextBox, exception.Message);
                RatingTextBox.BackColor = _wrongColor;
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
            HeightPanelTextBox.BackColor = _correctColor;
            XPanelTextBox.BackColor = _correctColor;
            YPanelTextBox.BackColor = _correctColor;
            WidthPanelTextBox.BackColor = _correctColor;

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

        private void AddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.rectangle_add;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Properties.Resources.rectangle_add__uncolor;
        }

        private void DeletePictureBox_MouseEnter(object sender, EventArgs e)
        {
            DeletePictureBox.Image = Properties.Resources.rectangle_remove;
        }

        private void DeletePictureBox_MouseLeave(object sender, EventArgs e)
        {
            DeletePictureBox.Image = Properties.Resources.rectangle_remove_uncolor;
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglesPanel.Count; i++)
            {
                _rectanglesPanel[i].BackColor = _correctColorPanel;
            }

            for (int i = 0; i< _rectanglesPanel.Count; i++)
            {
                for (int j = i+1; j < _rectanglesPanel.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglesPanel[i].BackColor = _wrongColorPanel;
                        _rectanglesPanel[j].BackColor = _wrongColorPanel;
                    }
                }
            }

        }

        private void NewPanel(Rectangle rectangle)
        {
            Panel panel = new Panel();
            panel.BackColor = _correctColorPanel;
            panel.Location = new Point(
                (int)rectangle.Center.X,
                (int)rectangle.Center.Y);
            panel.Width = (int)rectangle.Width;
            panel.Height = (int)rectangle.Length;
            _rectanglesPanel.Add(panel);
            RectanglePanel.Controls.Add(panel);
        }

        private string GetRectangleInfo()
        {
            return $"{_currentRectangle.Id}:" +
                $"(X = {_currentRectangle.Center.X};" +
                $"Y = {_currentRectangle.Center.Y};" +
                $"W = {_currentRectangle.Width};" +
                $"H = {_currentRectangle.Length})";
        }

        private void UpdatePanel(Panel panel)
        {
            panel.BackColor = _correctColorPanel;
            panel.Location = new Point(
                (int)_currentRectangle.Center.X,
                (int)_currentRectangle.Center.Y);
            panel.Width = (int)_currentRectangle.Width;
            panel.Height = (int)_currentRectangle.Length;
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {

            RectangleFactory.Randomize(_rectangles);

            _currentRectangle = _rectangles[_rectangles.Count- 6];
            RectanglesPanelListBox.Items.Add(GetRectangleInfo());
            NewPanel(_currentRectangle);
            FindCollisions();
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
                _rectanglesPanel.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                RectanglePanel.Controls.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                RectanglesPanelListBox.Items.RemoveAt(RectanglesPanelListBox.SelectedIndex);
                if (RectanglesPanelListBox.Items.Count > 0)
                {
                    RectanglesPanelListBox.SelectedIndex = 0;
                }
            }
            FindCollisions();
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
                    GetRectangleInfo();
        }

        private void HeightPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle == null)
            {
                return;
            }
            try
            {
                _currentRectangle.Length = Convert.ToInt32(HeightPanelTextBox.Text);
                HeightPanelTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(HeightPanelTextBox, "");
                UpdateRectangleInfo(_currentRectangle);
                UpdatePanelListBox();
                UpdatePanel(_rectanglesPanel[RectanglesPanelListBox.SelectedIndex]);
                FindCollisions();
            }
            catch (Exception exception)
            {
                Validator.AssertOnPositiveValue(_currentRectangle.Length, 
                                                nameof(HeightPanelTextBox));
                HeightPanelTextBox.BackColor = _wrongColor;
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
                XPanelTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(XPanelTextBox, "");
                UpdateRectangleInfo(_currentRectangle);
                UpdatePanelListBox();
                UpdatePanel(_rectanglesPanel[RectanglesPanelListBox.SelectedIndex]);
                FindCollisions();
            }
            catch (Exception exception)
            {
                XPanelTextBox.BackColor = _wrongColor;
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
                YPanelTextBox.BackColor = _correctColor;
                _currentRectangle.Center.Y = Int32.Parse(YPanelTextBox.Text);
                toolTip.SetToolTip(YPanelTextBox, "");
                UpdateRectangleInfo(_currentRectangle);
                UpdatePanelListBox();
                UpdatePanel(_rectanglesPanel[RectanglesPanelListBox.SelectedIndex]);
                FindCollisions();
            }
            catch (Exception exception)
            {
                YPanelTextBox.BackColor = _wrongColor;
                toolTip.SetToolTip(YPanelTextBox, exception.Message);
                return;
            }
        }

        private void WidthPanelTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = Convert.ToInt32(WidthPanelTextBox.Text);
                WidthPanelTextBox.BackColor = _correctColor;
                toolTip.SetToolTip(WidthPanelTextBox, "");
                UpdateRectangleInfo(_currentRectangle);
                UpdatePanelListBox();
                UpdatePanel(_rectanglesPanel[RectanglesPanelListBox.SelectedIndex]);
                FindCollisions();
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(WidthPanelTextBox, exception.Message);
                WidthPanelTextBox.BackColor = _wrongColor;
                return;
            }
        }
    }
}
