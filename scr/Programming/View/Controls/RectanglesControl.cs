using Programming.Model.Classes;
using Programming.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private Rectangle[] _rectangles = new Rectangle[5];

        private Rectangle _currentRectangle = new Rectangle();

        public RectanglesControl()
        {
            InitializeComponent();
            InitRectangles();
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
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

        private void InitRectangles()
        {
            RectangleFactory.RandomizeMassiv(_rectangles);
            for (int i = 0; i < 5; i++)
            {
                RectanglesListBoxInClasses.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBoxInClasses.SelectedIndex = 0;
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
                LengthTextBox.BackColor = AppColors.CorrectColor;
                toolTip.SetToolTip(LengthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(LengthTextBox, exception.Message);
                LengthTextBox.BackColor = AppColors.WrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: " +
                $"{CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = (int)Convert.ToDouble(WidthTextBox.Text);
                WidthTextBox.BackColor = AppColors.CorrectColor;
                toolTip.SetToolTip(WidthTextBox, "");
            }
            catch (Exception exception)
            {
                toolTip.SetToolTip(WidthTextBox, exception.Message);
                WidthTextBox.BackColor = AppColors.WrongColor;
            }
            CollisionLabel.Text = $"Rectangles 1 and 2 collide?: " +
                $"{CollisionManager.IsCollision(_rectangles[0], _rectangles[1])}";
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }
    }
}
