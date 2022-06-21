using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movies.Model;
using Movies.Model.Classes;
using Movies.Properties;
using Newtonsoft.Json;

namespace Movies.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Всплывающее описание TextBox. 
        /// </summary>
        private ToolTip _toolTip = new ToolTip();

        /// <summary>
        /// Список фильмов.
        /// </summary>
        private List<Movie> _movies = new List<Movie>();

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        private void AddPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPictureBox.Image = Resources.Video_add_color;
        }

        private void AddPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPictureBox.Image = Resources.Video_add;
        }

        private void RefreshPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RefreshPictureBox.Image = Resources.Video_refresh;
        }

        private void RefreshPictureBox_MouseEnter(object sender, EventArgs e)
        {
            RefreshPictureBox.Image = Resources.Video_refresh_color;
        }

        private void RemovePictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Resources.Video_remove;
        }

        private void RemovePictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemovePictureBox.Image = Resources.Video_remove_color;
        }

        /// <summary>
        /// Находит индекс жанра из перечисления.
        /// </summary>
        /// <param name="genre">Выбранный жанр.</param>
        /// <returns>Возвращает индекс жанра, который выбрал пользователь.</returns>
        private int SelectedGenre(Genres genre)
        {
            return (int) genre;
        }

        /// <summary>
        /// Обновляет информацию в ListBox.
        /// </summary>
        private void UpdateMoviesListBox()
        {
            MoviesListBox.Items [MoviesListBox.SelectedIndex] =
                    GetMovieInfo(_currentMovie);
        }

        /// <summary>
        /// Обновляет информацию во всех TextBox.
        /// </summary>
        private void UpdateMovieInfo()
        {
            TitleTextBox.Text = _currentMovie.Title.ToString();
            YearTextBox.Text = _currentMovie.Year.ToString();
            GenreComboBox.SelectedIndex = SelectedGenre(_currentMovie.Genre);
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            DurationTextBox.Text = _currentMovie.Duration.ToString();
        }

        /// <summary>
        /// Очищает информацию из всех TextBox.
        /// </summary>
        private void ClearMovieInfo()
        {
            _currentMovie = null;
            GenreComboBox.SelectedIndex = -1;
            GenreComboBox.BackColor = AppColors.CorrectColor;
            TitleTextBox.Text = "";
            TitleTextBox.BackColor = AppColors.CorrectColor;
            YearTextBox.Text = "";
            YearTextBox.BackColor = AppColors.CorrectColor;
            RatingTextBox.Text = "";
            RatingTextBox.BackColor = AppColors.CorrectColor;
            DurationTextBox.Text = "";
            DurationTextBox.BackColor = AppColors.CorrectColor;
        }

        /// <summary>
        /// Предоставляет информацию о фильме в заданном виде.
        /// </summary>
        /// <param name="movie">Фильм.</param>
        /// <returns>Возвращает строку, состоящую из названия фильма, года выпуска и жанра.</returns>
        private string GetMovieInfo(Movie movie)
        {
            return $"{movie.Title} | {movie.Year} | {movie.Genre}";
        }

        /// <summary>
        /// Устанавливает текущий фильм.
        /// </summary>
        private void SetCurrentMovie()
        {
            var index = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[index];
        }

        /// <summary>
        /// Сортировка списка и ListBox по названию фильма.
        /// </summary>
        /// <param name="movies">Фильмы.</param>
        private void TitleSort(List<Movie> movies)
        {
            var sortedMovies = movies.OrderBy(movie => movie.Title).ToList();
            for (int i = 0; i < MoviesListBox.Items.Count; i++)
            {
                MoviesListBox.Items[i] = GetMovieInfo(movies[i]);
                movies[i] = sortedMovies[i];
            }
        }

        public MainForm()
        {
            InitializeComponent();
            var values = Enum.GetValues(typeof(Genres));
            foreach (var value in values)
            {
                GenreComboBox.Items.Add(value);
            }
        }

        private void AddPictureBox_Click(object sender, EventArgs e)
        {
            _movies.Add(new Movie());
            _currentMovie = _movies[_movies.Count - 1];
            MoviesListBox.Items.Add(GetMovieInfo(_currentMovie));
            MoviesListBox.SelectedIndex = MoviesListBox.Items.Count - 1;

        }

        private void RemovePictureBox_Click(object sender, EventArgs e)
        {
            if (_currentMovie == null || MoviesListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                _movies.RemoveAt(MoviesListBox.SelectedIndex);
                MoviesListBox.Items.RemoveAt(MoviesListBox.SelectedIndex);
                if (MoviesListBox.Items.Count > 0)
                {
                    MoviesListBox.SelectedIndex = 0;
                }
            }
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TitleTextBox.SelectionStart = TitleTextBox.Text.Length;
                SetCurrentMovie();
                _currentMovie.Title = TitleTextBox.Text;
                _toolTip.SetToolTip(TitleTextBox, "");
                TitleTextBox.BackColor = AppColors.CorrectColor;
                UpdateMovieInfo();
                UpdateMoviesListBox();
            }
            catch (Exception exception)
            {
                TitleTextBox.BackColor = AppColors.WrongColor;
                _toolTip.SetToolTip(TitleTextBox, exception.Message);
            }
           
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                YearTextBox.SelectionStart = YearTextBox.Text.Length;
                SetCurrentMovie();
                _currentMovie.Year = Convert.ToInt32(YearTextBox.Text);
                _toolTip.SetToolTip(YearTextBox, "");
                YearTextBox.BackColor = AppColors.CorrectColor;
                UpdateMovieInfo();
                UpdateMoviesListBox();
            }
            catch (Exception exception)
            {
               YearTextBox.BackColor = AppColors.WrongColor;
               _toolTip.SetToolTip(YearTextBox, exception.Message);
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.SelectionStart = RatingTextBox.Text.Length;
                SetCurrentMovie();
                _currentMovie.Rating = Convert.ToDouble(RatingTextBox.Text);
                _toolTip.SetToolTip(RatingTextBox,"");
                RatingTextBox.BackColor = AppColors.CorrectColor;
                UpdateMovieInfo();
                UpdateMoviesListBox();
            }
            catch (Exception exception)
            {
                RatingTextBox.BackColor = AppColors.WrongColor;
                _toolTip.SetToolTip(RatingTextBox, exception.Message);
            }
        }

        private void RatingTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RatingTextBox.Text = RatingTextBox.Text.Replace(".", ",");
        }

        private void RatingTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            RatingTextBox.Text = RatingTextBox.Text.Replace(".", ",");
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GenreComboBox.SelectionStart = GenreComboBox.Text.Length;
                SetCurrentMovie();
                _currentMovie.Genre = (Genres)GenreComboBox.SelectedIndex;
                _toolTip.SetToolTip(GenreComboBox, "");
                GenreComboBox.BackColor = AppColors.CorrectColor;
                UpdateMovieInfo();
                UpdateMoviesListBox();
            }
            catch (Exception exception)
            {
                GenreComboBox.BackColor = AppColors.WrongColor;
                _toolTip.SetToolTip(GenreComboBox, exception.Message);
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DurationTextBox.SelectionStart = DurationTextBox.Text.Length;
                SetCurrentMovie();
                _currentMovie.Duration = Convert.ToInt32(DurationTextBox.Text);
                _toolTip.SetToolTip(DurationTextBox, "");
                DurationTextBox.BackColor = AppColors.CorrectColor;
                UpdateMovieInfo();
                UpdateMoviesListBox();
            }
            catch (Exception exception)
            {
                DurationTextBox.BackColor = AppColors.WrongColor;
                _toolTip.SetToolTip(DurationTextBox, exception.Message);
            }
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MoviesListBox.SelectedIndex == -1)
            {
                ClearMovieInfo();
            }
            else
            {
                _currentMovie = _movies[MoviesListBox.SelectedIndex];
                UpdateMovieInfo();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _movies.AddRange(ProjectSerializer.LoadMoviesToFile());
            for (int i = 0; i < _movies.Count; i++)
            {
                MoviesListBox.Items.Add(GetMovieInfo(_movies[i]));
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
           ProjectSerializer.SaveMoviesToFile(_movies);
        }

        private void RefreshPictureBox_Click(object sender, EventArgs e)
        {
            TitleSort(_movies);
        }
    }
}
