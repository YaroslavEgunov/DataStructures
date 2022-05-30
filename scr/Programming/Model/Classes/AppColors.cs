using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class AppColors
    {
        public static readonly Color WrongColor = Color.LightPink;

        public static readonly Color CorrectColor = Color.White;

        public static readonly Color CorrectColorPanel = Color.FromArgb
            (127, 127, 255, 127);

        public static readonly Color WrongColorPanel = Color.FromArgb
            (127, 255, 127, 127);

        public static readonly Color SpringColor = Color.LightGreen;

        public static readonly Color AutumnColor = Color.Orange;

        public static readonly Color NoneColor = Color.White;

    }
}
